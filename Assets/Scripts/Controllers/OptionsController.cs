using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    public Toggle MuteSoundToggle;

    void Start()
    {
        if (GameManager.OptionsManager.IsSoundMuted)
        {
            MuteSoundToggle.isOn = true;
        }
        else
        {
            MuteSoundToggle.isOn = false;
        }
    }

    public void MuteSoundToggleSwitch()
    {
        GameManager.OptionsManager.IsSoundMuted = !GameManager.OptionsManager.IsSoundMuted;
    }
}
