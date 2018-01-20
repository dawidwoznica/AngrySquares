using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectController : MonoBehaviour
{

    private Text _levelButtonText;

    void Awake()
    {
        _levelButtonText = GetComponentInChildren<Text>();
    }

    public void SelectLevel()
    {
        GameManager.PlayerManager.ActualLevelNumber = Int32.Parse(_levelButtonText.text);
        SceneManager.LoadScene("scn_Lvl" + _levelButtonText.text);
    }
}
