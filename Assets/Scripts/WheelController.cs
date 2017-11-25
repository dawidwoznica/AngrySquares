using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RotateForward()
    {
        transform.Rotate(0, 0, Time.deltaTime * Speed);
    }

    public void RotateBackward()
    {
        transform.Rotate(0, 0, -Time.deltaTime * Speed);
    }
}
