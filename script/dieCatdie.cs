using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieCatdie : MonoBehaviour
{

    Animator anim;
    [SerializeField]
    GameObject caniPanel;

    public bool catisDie;

    [SerializeField]
    AudioSource pp;



    void Start()
    {
        anim = GetComponent<Animator>();
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sopa"))
        {
            //Debug.Log("HASAR");
            anim.SetBool("isDieCat", true);
            Invoke("caniPlayer",1f);
            Invoke("cancelInvoke",2.3f);
            gameObject.GetComponent<AudioSource>().Stop();
            GameObject.FindGameObjectWithTag("catDie").gameObject.GetComponent<AudioSource>().Play();
            
            catisDie = true;
        }
    }

    void caniPlayer()
    {
        caniPanel.SetActive(true);
        pp.Play();
    }

    void cancelInvoke()
    {
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        caniPanel.SetActive(false);
        CancelInvoke("caniPlayer");
    }
}
