using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("scn_Lvl1", LoadSceneMode.Single);
    }

    public void Levels()
    {
        SceneManager.LoadScene("scn_Levels", LoadSceneMode.Single);
    }

    public void Options()
    {
        SceneManager.LoadScene("scn_Options", LoadSceneMode.Single);
    }

    public void Credits()
    {
        SceneManager.LoadScene("scn_Credits", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
