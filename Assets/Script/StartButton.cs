using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
  

	public void ChangeToGame()
	{
		// Load the game scene
		SceneManager.LoadScene("game");
		Debug.Log("Game scene loaded");
	}
}
