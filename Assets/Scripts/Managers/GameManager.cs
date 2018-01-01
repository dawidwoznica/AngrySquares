using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public static CannonManager CannonManager;
    public static KegManager KegManager;
    public static PlayerManager PlayerManager;
    public static OptionsManager OptionsManager;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        GetManagers();
        DontDestroyOnLoad(gameObject);
    }

    private void GetManagers()
    {
        CannonManager = GetComponent<CannonManager>();
        KegManager = GetComponent<KegManager>();
        PlayerManager = GetComponent<PlayerManager>();
        OptionsManager = GetComponent<OptionsManager>();
    }
}
