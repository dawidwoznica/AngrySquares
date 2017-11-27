using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour {

    public GameObject Explosion;
    private AudioSource _boomSound;

    void Awake()
    {
        _boomSound = GetComponent<AudioSource>();
    }

	void Start () {
		//Destroy(gameObject, 5);
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(Explosion, transform.position, transform.rotation);
        //Destroy(other.gameObject, 3);
        _boomSound.Play();
        //gameObject.SetActive(false);
        //Destroy(gameObject, 2);
    }
}
