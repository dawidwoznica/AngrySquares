﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D other)
	{
	    if (other.gameObject.layer == 8)
	    {
	        Destroy(gameObject, 0.1f);
	    }
	}
}