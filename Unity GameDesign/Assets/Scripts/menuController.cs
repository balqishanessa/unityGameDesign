using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControllerScript : MonoBehaviour {

	void Start()
	{
	}

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		SceneManager.LoadScene ("matchMode");
	}

}
