using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        Debug.Log("loaded");

        Application.LoadLevel(1);
    }

    public void Options()
    {
        
    }

    public void Credits()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
