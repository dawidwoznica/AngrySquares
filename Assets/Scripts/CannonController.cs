using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class CannonController : MonoBehaviour {

	public float FirePower;
	public GameObject CannonBall;
	Rigidbody2D _cannonBallRB;
	public Transform ShotPosition;
    public float BarrelRotationSpeed;
    public CannonMovementController CannonMovementController;


    private ParticleSystem _shootEffect;
	private AudioSource _cannonShoot;

    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;

	// Use this for initialization
	void Start ()
	{
		_cannonShoot = GetComponent<AudioSource>();
		_shootEffect = GetComponentInChildren<ParticleSystem>();

        keywordActions.Add("fire", Shoot);
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
        keywordRecognizer.Start();
	}

    private void OnKeyRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Keyword: "+ args.text);
        keywordActions[args.text].Invoke();
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


    public void Up()
    {
        transform.Rotate(0, 0, Time.deltaTime * BarrelRotationSpeed);
    }

    public void Down()
    {
        transform.Rotate(0, 0, -Time.deltaTime * BarrelRotationSpeed);
    }
}
