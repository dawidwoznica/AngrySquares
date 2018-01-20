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

    [HideInInspector]
    public bool IsGameFinished;


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
            if (!IsGameFinished && !GameObject.FindWithTag("Keg"))
            {
                StartCoroutine(FinishTheLevel());
                IsGameFinished = true;

        }
    }

    void CheckAmountOfCannonBalls()
    {
        if (!IsGameFinished && GameManager.PlayerManager.CannonBallsLeft == 0)
        {
            StartCoroutine(WaitAndCheckKegsThenRestartIfNeeded());
        }
    }

    IEnumerator WaitAndCheckKegsThenRestartIfNeeded()
    {
        yield return new WaitForSeconds(2);
        CheckIfKegsExists();
        if (!IsGameFinished)
        {
            StartCoroutine(RestartLevel());
            IsGameFinished = true;
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

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(1);

        EndGameCanvas.gameObject.SetActive(true);

        EndGameText.text = @"You don't have more cannonballs

Try again";

        yield return new WaitForSeconds(5);

        ReloadLevel();
    }

    IEnumerator WaitSomeTime()
    {
        yield return new WaitForSeconds(2);
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

    void ReloadLevel()
    {
        SceneManager.LoadScene("scn_Lvl" + GameManager.PlayerManager.ActualLevelNumber);
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
