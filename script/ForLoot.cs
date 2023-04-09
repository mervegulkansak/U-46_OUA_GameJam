using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForLoot : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    GameObject sagEl;
    [SerializeField]
    GameObject eBas;
    [SerializeField]
    GameObject vurBild;
    [SerializeField]
    GameObject sopaIcon;

    public bool batInHand;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            //Debug.Log("sopayla etkileþim.");
            if (Input.GetKeyDown(KeyCode.E))
            {
                sopaAl();
                eBas.gameObject.SetActive(false);
                sopaIcon.gameObject.SetActive(true);
                gameObject.GetComponent<CapsuleCollider>().enabled = false;
                StartCoroutine(vurBildiri());
                batInHand= true;
            }
        }
    }


    public void sopaAl()
    {
        gameObject.transform.SetParent(sagEl.transform);
        gameObject.transform.localPosition = new Vector3(0.5f, 0f, 0.5f);
        gameObject.transform.localRotation = Quaternion.Euler(-45f, 0f, 90f);
    }

    IEnumerator vurBildiri()
    {
        yield return new WaitForSeconds(.8f);
        vurBild.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        vurBild.gameObject.SetActive(false);
    }
    

    public IEnumerator sopaColl()
    {
        Debug.Log("sopaColl working");
        yield return new WaitForSeconds(.2f);
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
        yield return new WaitForSeconds(.7f);
        gameObject.GetComponent<CapsuleCollider>().enabled = false;

    }
}
