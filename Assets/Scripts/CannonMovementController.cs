using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovementController : MonoBehaviour {


    public WheelController WheelController;
    public float CannonSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.RightArrow))
        {
            WheelController.RotateForward();
            transform.position += new Vector3(Time.deltaTime * CannonSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            WheelController.RotateBackward();
            transform.position -= new Vector3(Time.deltaTime * CannonSpeed, 0, 0);
        }
    }
}
