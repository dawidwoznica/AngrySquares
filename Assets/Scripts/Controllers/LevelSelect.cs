using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    private Text _levelButtonText;

    void Awake()
    {
        _levelButtonText = GetComponentInChildren<Text>();
    }

    public void SelectLevel()
    {
        GameObject.Find("BackgroundMusic").GetComponent<AudioSource>().Stop();
        //GameObject.Find("BackgroundWind").GetComponent<AudioSource>().Stop();
        //GameObject.Find("Dust").GetComponent<ParticleSystem>().Stop();
        GameManager.PlayerManager.ActualLevelNumber = Int32.Parse(_levelButtonText.text);
        SceneManager.LoadScene("scn_Lvl" + _levelButtonText.text);
    }
}
