using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CannonController : MonoBehaviour {

	Rigidbody2D _cannonBallRB;
	public CannonMovementController CannonMovementController;
    public Transform ShotPosition;
    public ParticleSystem CannonShootEffect;


    private AudioSource _cannonShoot;

/*    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
	private KeywordRecognizer keywordRecognizer;*/

	// Use this for initialization
	void Start ()
	{
		_cannonShoot = GetComponent<AudioSource>();
	    GameManager.PlayerManager.CannonBallsLeft = 4;

	    /*   keywordActions.Add("fire", Shoot);
           keywordActions.Add("shoot", Shoot);
           keywordActions.Add("shot", Shoot);
           keywordActions.Add("up", Up);
           keywordActions.Add("down", Down);
           keywordActions.Add("upper", Up);
           keywordActions.Add("lower", Down);
           keywordActions.Add("left", CannonMovementController.Left);
           keywordActions.Add("right", CannonMovementController.Right);
           keywordActions.Add("go left", CannonMovementController.Left);
           keywordActions.Add("go right", CannonMovementController.Right);
           keywordActions.Add("move left", CannonMovementController.Left);
           keywordActions.Add("move right", CannonMovementController.Right);
   
           keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
           keywordRecognizer.OnPhraseRecognized += OnKeyRecognized;
           keywordRecognizer.Start();*/
	}
	
   /* private void OnKeyRecognized(PhraseRecognizedEventArgs args)
	{
		Debug.Log("Keyword: "+ args.text);
		keywordActions[args.text].Invoke();
	}*/


	// Update is called once per frame
	void Update () {

	}

	public void Shoot()
	{
		if (!GameManager.OptionsManager.IsSoundMuted)
		{
			_cannonShoot.Play();
		}
		CannonShootEffect.Play();
		GameObject _cannonBallCopy = Instantiate(GameManager.CannonManager.CannonBall, ShotPosition.position, transform.rotation);
		_cannonBallRB = _cannonBallCopy.GetComponent<Rigidbody2D>();
		_cannonBallRB.AddForce(transform.right * GameManager.CannonManager.FirePower);
	    GameManager.PlayerManager.CannonBallsLeft--;
	}


	public void Up()
	{
		transform.Rotate(0, 0, Time.deltaTime * GameManager.CannonManager.BarrelRotationSpeed);
	}

	public void Down()
	{
		transform.Rotate(0, 0, -Time.deltaTime * GameManager.CannonManager.BarrelRotationSpeed);
	}
}
