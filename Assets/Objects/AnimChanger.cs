using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChanger : MonoBehaviour
{

    private Animator Anim;
    private void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Anim.Play("Anim1");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Anim.Play("Anim2");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Anim.Play("Anim3");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Anim.Play("Anim4");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Anim.Play("Anim5");
        }
    }
}
