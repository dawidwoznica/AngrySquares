using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMovementController : MonoBehaviour {


    public float BarrelRotationSpeed;


	void Update () {
	    if (Input.GetKey(KeyCode.UpArrow))
	    {
	        transform.Rotate(0, 0, Time.deltaTime * BarrelRotationSpeed);
	    }

	    if (Input.GetKey(KeyCode.DownArrow))
	    {
	        transform.Rotate(0, 0, -Time.deltaTime * BarrelRotationSpeed);
	    }
    }
}
