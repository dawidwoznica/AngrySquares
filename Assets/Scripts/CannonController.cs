using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

    public float FirePower;
    public GameObject CannonBall;
    Rigidbody2D _cannonBallRB;
    public Transform ShotPosition;

    private ParticleSystem _shootEffect;
    private AudioSource _cannonShoot;

	// Use this for initialization
	void Start ()
	{
	    _cannonShoot = GetComponent<AudioSource>();
	    _shootEffect = GetComponentInChildren<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Shoot()
    {
        _cannonShoot.Play();
        _shootEffect.Play();
        GameObject _cannonBallCopy = Instantiate(CannonBall, ShotPosition.position, transform.rotation) as GameObject;
        _cannonBallRB = _cannonBallCopy.GetComponent<Rigidbody2D>();
        _cannonBallRB.AddForce(transform.right * FirePower);
    }
}
