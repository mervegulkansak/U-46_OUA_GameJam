using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class EnemyAttacking : MonoBehaviour
{

    NavMeshAgent enemy;
    [SerializeField]
    GameObject target;
    [SerializeField]
    AudioSource enemyHits;

    int enemyHealt = 4;

    Animator anim;

    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sopa"))
        {
            enemyHits.Play();
            enemyHealt--;
            //Debug.Log("hasar hasar");

            if (enemyHealt == 0)
            {
                gameObject.GetComponent<Animator>().enabled = false;
                gameObject.GetComponent<NavMeshAgent>().enabled = false;
                gameObject.GetComponent<CapsuleCollider>().enabled= false;
                Destroy(gameObject,4f);
            }
        }
    }



    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, target.transform.position);
        //Debug.Log(dist);
        if (dist < 30)
        {
            enemy.SetDestination(target.transform.position);
            anim.SetBool("isTarget", true);

            if (dist < 2)
            {
                anim.SetBool("enemyAttack", true);
            }
            else
            {
                anim.SetBool("isTarget", true);
                anim.SetBool("enemyAttack", false);
            }

        }
    }
}
