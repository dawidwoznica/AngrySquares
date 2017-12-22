using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public static CannonManager CannonManager;
    public static KegManager KegManager;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        GetManagers();
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void GetManagers()
    {
        CannonManager = GetComponent<CannonManager>();
        KegManager = GetComponent<KegManager>();
    }
}
