using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    public void StartGame()
    {
        GameObject.Find("BackgroundMusic").GetComponent<AudioSource>().Stop();
        //GameObject.Find("BackgroundWind").GetComponent<AudioSource>().Stop();
        //GameObject.Find("Dust").GetComponent<ParticleSystem>().Stop();
        GetActualLevelFromFile();
        SceneManager.LoadScene("scn_Lvl" + GameManager.PlayerManager.ActualLevelNumber, LoadSceneMode.Single);
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

    void GetActualLevelFromFile()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "ActualLevel.txt");
        StreamReader sr = new StreamReader(path);
        string line = sr.ReadLine();
        if (line != null)
        {
            GameManager.PlayerManager.ActualLevelNumber = Int32.Parse(line);
        }
        sr.Close();
    }
}
