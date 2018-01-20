using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnGameEnd : MonoBehaviour
{
    private GameController _gameController;


    void Awake()
    {
        GameObject gameObject = GameObject.Find("GameController");
        _gameController = gameObject.GetComponent<GameController>();
    }

	// Update is called once per frame
	void Update () {
	    if (_gameController.IsGameFinished)
	    {
	        Destroy(gameObject);
	    }
	}
}
