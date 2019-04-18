using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAudio : MonoBehaviour {

    static destroyAudio instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(transform.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

}
