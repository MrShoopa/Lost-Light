using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILevelComplete : MonoBehaviour
{
	public void AdvanceToNext()
	{
		Application.Quit();
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void RedoLevel()
	{
		SceneManager.LoadScene("Level1");
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
