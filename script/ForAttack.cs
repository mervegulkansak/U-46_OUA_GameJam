using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForAttack : MonoBehaviour
{

    Animator myAnim;

    void Start()
    {
           Cursor.visible= false;
           myAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("mouse 1 attack");
            myAnim.Play("attackT");
            if (GameObject.FindGameObjectWithTag("sopa").GetComponent<ForLoot>().batInHand)
            {
                StartCoroutine(GameObject.FindGameObjectWithTag("sopa").GetComponent<ForLoot>().sopaColl());
            }
        }
    }
}
