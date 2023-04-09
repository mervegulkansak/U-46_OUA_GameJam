using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCams : MonoBehaviour
{
    [SerializeField]
    Camera cam1, cam2;

    [SerializeField]
    GameObject player, andcam, fake, forKeys;


    private void Start()
    {
        Invoke("firstC", 4.3f);
        Invoke("forCam2", 10.9f);

    }

    void firstC()
    {
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
    }


    void forCam2()
    {
        cam1.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        andcam.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        fake.gameObject.SetActive(false);
        forKeys.gameObject.SetActive(true);

    }
}
