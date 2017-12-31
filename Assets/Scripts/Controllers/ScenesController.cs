using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{

    public PlayerController PlayerController;

	// Use this for initialization
	void Start () {
       
        PlayerController.Reset(8, 6);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
