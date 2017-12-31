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
        SceneManager.LoadScene("scn_Lvl" + _levelButtonText.text);
    }
}
