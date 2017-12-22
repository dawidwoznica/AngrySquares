using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {

    public float WheelRotationSpeed;


    public void RotateForward()
    {
        transform.Rotate(0, 0, -Time.deltaTime * WheelRotationSpeed);
    }

    public void RotateBackward()
    {
        transform.Rotate(0, 0, Time.deltaTime * WheelRotationSpeed);
    }
}
