using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlockController : MonoBehaviour
{

	public Button[] LevelButtons;

	// Use this for initialization
	void Start () {
		string supportPath = Path.Combine(Application.streamingAssetsPath, "UnlockedLevels.txt");
		string line = ReadFile(supportPath);

		foreach (Button levelButton in LevelButtons)
		{
			if (Int32.Parse(levelButton.GetComponentInChildren<Text>().text) > Int32.Parse(line))
			{
				levelButton.interactable = false;
			}			
		}
	}


	string ReadFile(string path)
	{
		WWW reader = new WWW(path);
		while (!reader.isDone)
		{
		}
		string line = reader.text;

		return line;
	}
}
