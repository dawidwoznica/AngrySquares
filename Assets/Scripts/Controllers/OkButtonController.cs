using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkButtonController : MonoBehaviour
{

    public Canvas HintUI;

    public void HideUI()
    {
        HintUI.gameObject.SetActive(false);
    }
}
