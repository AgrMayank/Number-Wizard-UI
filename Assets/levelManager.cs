﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{

		Debug.Log("Level Load Requested for " + name);
		//Application.LoadLevel(name);
		SceneManager.LoadScene(name);

	}

	public void QuitRequest()
	{

		Debug.Log("I want to Quit the Game");
		Application.Quit();

	}
}
