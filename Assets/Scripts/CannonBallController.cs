using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour {

    public GameObject Explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Explosion, transform.position, transform.rotation);
        //Destroy(other.gameObject, 3);
        Destroy(gameObject);
    }
}
