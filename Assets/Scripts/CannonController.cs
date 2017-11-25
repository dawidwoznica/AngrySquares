using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    public float FirePower;
    public GameObject CannonBall;
    Rigidbody2D _cannonBallRB;
    public Transform ShotPosition;
    public float RotationSpeed;
    public WheelController WheelController;
    public float Speed;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, Time.deltaTime * RotationSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -Time.deltaTime * RotationSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            WheelController.RotateForward();
            transform.position += transform.forward * Time.deltaTime * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            WheelController.RotateBackward();
            transform.position -= transform.forward * Time.deltaTime * Speed;
        }
    }

    public void Shoot()
    {
        GameObject _cannonBallCopy = Instantiate(CannonBall, ShotPosition.position, transform.rotation) as GameObject;
        _cannonBallRB = _cannonBallCopy.GetComponent<Rigidbody2D>();
        _cannonBallRB.AddForce(transform.right * FirePower);
    }
}
