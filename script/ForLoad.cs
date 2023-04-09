using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ForLoad : MonoBehaviour
{
    [SerializeField]
    GameObject startThenLoad;
    [SerializeField]
    Slider forSlid;

    public void gameStart(int Lv_Id)
    {
        StartCoroutine(forLoadingScene(Lv_Id));
    }

    IEnumerator forLoadingScene(int index)
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(1);
        startThenLoad.SetActive(true);

        while (!oper.isDone)
        {
            float prog = Mathf.Clamp01(oper.progress / .9f);
            forSlid.value = prog;
            yield return null;

        }
    }
}
