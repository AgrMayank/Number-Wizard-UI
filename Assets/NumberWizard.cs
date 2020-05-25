using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int min;
	int max;
	int guess;
	int maxGuessesAllowed = 10;

	public Text text;

	void Start () {

		StartGame();

	}

	void StartGame()
	{

		max = 100;
		min = 1;
		NextGuess();

	}

	void NextGuess()
	{

		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;

		if(maxGuessesAllowed <=0)
		{
			//Application.LoadLevel("Win");
			SceneManager.LoadScene("Win");
		}
	}

	public void GuessHigher ()
	{
		min = guess;
		NextGuess();
	}
	public void Guesslower ()
	{
		max = guess;
		NextGuess();
	}
}
