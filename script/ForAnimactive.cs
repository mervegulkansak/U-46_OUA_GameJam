using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForAnimactive : MonoBehaviour
{

    GameObject badguy;
    GameObject girl;
    GameObject man;


    void Start()
    {
        badguy = GameObject.FindGameObjectWithTag("badGuy");
        girl = GameObject.FindGameObjectWithTag("TheGirl");
        man = GameObject.FindGameObjectWithTag("bilimAdam");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("one") && other.gameObject.CompareTag("Player"))
        {
            badguy.gameObject.GetComponent<Animator>().enabled = true;    
            girl.gameObject.GetComponent<Animator>().enabled = true;
        }

        if (gameObject.CompareTag("two") && other.gameObject.CompareTag("Player"))
        {
            man.gameObject.GetComponent<Animator>().enabled = true;
            
        }
        Destroy(gameObject, 1.5f);
    }
}
