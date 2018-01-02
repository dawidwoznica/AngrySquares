using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyDust : MonoBehaviour {

    public static DontDestroyDust instance = null;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
