using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovementController : MonoBehaviour {


    public WheelController WheelController;
    public float CannonSpeed;
    private bool goRight;
    private bool goLeft;
    public float time;

    // Use this for initialization
    void Start ()
    {
        goRight = false;
        goLeft = false;
    }
	
	// Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.RightArrow) || goRight)
        {
            WheelController.RotateForward();
            transform.position += new Vector3(Time.deltaTime * CannonSpeed, 0, 0);
            if (Time.time >= time + 1f)
            {
                goRight = false;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || goLeft)
        {
            WheelController.RotateBackward();
            transform.position -= new Vector3(Time.deltaTime * CannonSpeed, 0, 0);
            if (Time.time >= time + 1f)
            {
                goLeft = false;
            }
        }
    }


    public void Right()
    {
        time = Time.time;
        goRight = true;
    }
    public void Left()
    {
        time = Time.time;
        goLeft = true;
    }
}
