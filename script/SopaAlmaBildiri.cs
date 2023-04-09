using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SopaAlmaBildiri : MonoBehaviour
{

    [SerializeField] 
    GameObject panel;
    



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("E için etkileþim");
            panel.gameObject.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("exit E için etkileþim");
            panel.gameObject.SetActive(false);
        }
    }
}
