using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    [SerializeField] private Animator _animator;
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

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            _animator.Play("Anim1");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            _animator.Play("Anim2");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            _animator.Play("Anim3");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            _animator.Play("Anim4");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            _animator.Play("Anim5");
        }

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