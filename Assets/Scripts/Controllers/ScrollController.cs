using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{

    private ScrollRect _scrollRect;

    void Awake ()
    {
        _scrollRect = GetComponent<ScrollRect>();
    }

    void Start()
    {
        _scrollRect.horizontalNormalizedPosition = 0f;
    }
}
