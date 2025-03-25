using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultButtons : MonoBehaviour
{
	public void MoveTitle()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("title");
	}

	public void MoveGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("game");
	}
}
