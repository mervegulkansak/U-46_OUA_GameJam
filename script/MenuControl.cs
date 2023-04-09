using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MenuControl : MonoBehaviour
{

    public void gameEnd() 
    {
        Application.Quit();
    }

   public void OnPointerEnter()
    {
       transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    public void OnPointerExit() 
    {
        transform.localScale = new Vector3(1f, 1f, 1f); //first;

    }


}
