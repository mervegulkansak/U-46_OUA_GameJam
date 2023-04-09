using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class theEnd : MonoBehaviour
{

    string duygu_Bir, duygu_Iki, duygu_Uc, karakter;
    //dieBilimAdami areTheyDied = new dieBilimAdami();
    //dieCatdie isCatDied = new dieCatdie();

    [SerializeField]
    GameObject forEndPanel;
    [SerializeField]
    Text karakText;

    private void Start()
    {
        karakText.text = " ";
    }

    void Update()
    {
        propS();

        if (duygu_Bir == "Satanist" && duygu_Iki == "Intýkam" && duygu_Uc == "Koruyucu")
        {
            karakter = "siddete egilimli";
        }
        karakText.text = karakter;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("finish", 1.5f);
        }
        
    }

    void finish()
    {
        forEndPanel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }


    void propS()
    {
        if (GameObject.FindGameObjectWithTag("cat").GetComponent<dieCatdie>().catisDie)
        {
            duygu_Bir = "Satanist";
            //Debug.Log(duygu_Bir);
        }
        if (GameObject.FindGameObjectWithTag("bilimAdam").GetComponent<dieBilimAdami>().manIsDie)
        {
            duygu_Iki = "Intýkam";
            //Debug.Log(duygu_Iki);
        }
        if (GameObject.FindGameObjectWithTag("badGuy").GetComponent<dieBilimAdami>().badIsDie)
        {
            duygu_Uc = "Koruyucu";
            //Debug.Log(duygu_Uc);
        }
    }
}
