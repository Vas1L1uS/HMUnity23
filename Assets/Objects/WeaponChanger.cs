using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] _weapons;

    private void ChangeWeaponNext(GameObject[] weapons)
    {
        weapons[0].SetActive(false);
        var temp = weapons[0];
        for (int i = 1; i < weapons.Length; i++)
        {
            weapons[i - 1] = weapons[i];
        }
        weapons[weapons.Length - 1] = temp;
        weapons[0].SetActive(true);
    }

    private void ChangeWeaponPrevious(GameObject[] weapons)
    {
        weapons[0].SetActive(false);
        var temp = weapons[weapons.Length - 1];
        for (int i = weapons.Length - 1; i > 0; i--)
        {
            weapons[i] = weapons[i - 1];
        }
        weapons[0] = temp;
        weapons[0].SetActive(true);
    }

    private void Update()
    {
        var mouseScroll = Input.GetAxis("Mouse ScrollWheel");

        if (mouseScroll != 0)
        {
            if (mouseScroll > 0)
            {       
                ChangeWeaponNext(_weapons);
            }
            else
            {
                ChangeWeaponPrevious(_weapons);
            }
        }
    }
}