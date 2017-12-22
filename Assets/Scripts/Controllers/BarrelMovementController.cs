using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrelMovementController : MonoBehaviour {


    public float BarrelRotationSpeed;

	void Update () {
	 
    }

    public void Up()
    {
        transform.Rotate(0, 0, Time.deltaTime * BarrelRotationSpeed);
    }

    public void Down()
    {
        transform.Rotate(0, 0, -Time.deltaTime * BarrelRotationSpeed);
    }
}
