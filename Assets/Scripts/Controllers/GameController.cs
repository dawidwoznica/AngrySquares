using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Canvas EndGameCanvas;
    public Text EndGameText;

    private bool _isGameFinished;


    void Start()
    {
        SaveLevelNumber();
    }

    void Update ()
    {
		CheckIfKegsExists();
        CheckAmountOfCannonBalls();
	}

    void CheckIfKegsExists()
    {    
            if (!_isGameFinished && !GameObject.FindWithTag("Keg"))
            {
                StartCoroutine(FinishTheLevel());
                _isGameFinished = true;

        }
    }

    void CheckAmountOfCannonBalls()
    {
        if (!_isGameFinished && GameManager.PlayerManager.CannonBallsLeft == 0)
        {            
            StartCoroutine(FinishTheLevel());
            _isGameFinished = true;
        }
    }

    IEnumerator FinishTheLevel()
    {
        yield return new WaitForSeconds(1);

        EndGameCanvas.gameObject.SetActive(true);

        EndGameText.text = @"Level finished!

Cannonballs left: " + GameManager.PlayerManager.CannonBallsLeft;

        yield return new WaitForSeconds(5);

        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        if (Application.CanStreamedLevelBeLoaded("scn_Lvl" + (GameManager.PlayerManager.ActualLevelNumber + 1)))
        {
            UpdateLevelNumber();
            SceneManager.LoadScene("scn_Lvl" + GameManager.PlayerManager.ActualLevelNumber);
        }
        else
        {
            GameManager.PlayerManager.ActualLevelNumber = 0;
            SceneManager.LoadScene("scn_MainMenu");
        }     
    }

    void UpdateLevelNumber()
    {
        GameManager.PlayerManager.ActualLevelNumber++;

        SaveLevelNumber();;
    }

    void SaveLevelNumber()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "ActualLevel.txt");
        File.WriteAllText(path, String.Empty);
        File.WriteAllText(path, GameManager.PlayerManager.ActualLevelNumber.ToString());
    }
}
