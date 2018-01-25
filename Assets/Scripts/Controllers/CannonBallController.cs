using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour {

	public GameObject Explosion;
	private AudioSource _boomSound;
	private bool _afterCollision;

	void Awake()
	{
		_boomSound = GetComponent<AudioSource>();
	}

	void Start ()
	{
		_afterCollision = false;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (!_afterCollision)
		{
			Instantiate(Explosion, transform.position, transform.rotation);
			//Destroy(other.gameObject, 3);
			if (other.gameObject.layer == 8)
			{
				Destroy(other.gameObject);
			}
			if (!GameManager.OptionsManager.IsSoundMuted)
			{
				_boomSound.Play();
			}
			if (!other.gameObject.tag.Equals("Bar"))
			{
				_afterCollision = true;

			}
			//gameObject.SetActive(false);
			//Destroy(gameObject, 2);

		}
	}
}
