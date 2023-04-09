using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dieBilimAdami : MonoBehaviour
{

    Animator anim;
    int enemyHealt = 3;
    public bool manIsDie, badIsDie;

    [SerializeField]
    GameObject manDiePan;

    [SerializeField]
    GameObject badDiePan;

    [SerializeField]
    GameObject forEnemyObject;

    [SerializeField]
    AudioSource enemyHit;
    [SerializeField]
    AudioSource pp;


    void Start()
    {
        anim= GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("badGuy") && other.gameObject.CompareTag("sopa"))
        {
            enemyHealt --;
            enemyHit.Play();
            //Debug.Log(enemyHealt);
            if (enemyHealt == 0)
            {
                anim.SetBool("isDieBad", true);
                badIsDie = true;
                StartCoroutine(capsuleOff());
                StartCoroutine(forActive());

            }
            //Debug.Log("HASAR");
            

        }

        if (gameObject.CompareTag("bilimAdam") && other.gameObject.CompareTag("sopa"))
        {
            //Debug.Log("HASAR");
            anim.SetBool("isDie", true);
            manIsDie = true;
            StartCoroutine(capsuleOff());
            StartCoroutine(forActive());
        }
    }


    IEnumerator forActive()
    {
        yield return new WaitForSeconds(.3f);

        if (gameObject.CompareTag("badGuy"))
        {
            badDiePan.SetActive(true);
            forEnemyObject.SetActive(true);
            pp.Play();
            yield return new WaitForSeconds(2f);
            badDiePan.SetActive(false);


        }

        if (gameObject.CompareTag("bilimAdam"))
        {
            manDiePan.SetActive(true);
            pp.Play();
            yield return new WaitForSeconds(2f);
            manDiePan.SetActive(false);
        }


    }


    IEnumerator capsuleOff()
    {
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }
}
