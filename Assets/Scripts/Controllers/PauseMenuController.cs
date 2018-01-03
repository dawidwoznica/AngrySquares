using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{

    public Canvas PauseMenuCanvas;

    public void ShowPauseMenu()
    {
        PauseMenuCanvas.enabled = true;
    }

    public void Resume()
    {
        PauseMenuCanvas.enabled = false;
    }

    public void MainMenu()
    {
        GameObject.Find("BackgroundMusic").GetComponent<AudioSource>().Play();
        GameObject.Find("BackgroundWind").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("scn_MainMenu", LoadSceneMode.Single);
    }

    public void Options()
    {
        SceneManager.LoadScene("scn_Options", LoadSceneMode.Additive);
    }
}
