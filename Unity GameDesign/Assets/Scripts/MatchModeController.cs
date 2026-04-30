using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchModeController : MonoBehaviour {

	public Sprite[] spriteMute;
	public Button buttonMute;
	public Button mode1Button;

	void Start()
	{
		//mute sound
		if(SoundManager.Instance.music.mute == true)
		{
			buttonMute.image.sprite = spriteMute[1];
		}
		else
		{
			buttonMute.image.sprite = spriteMute[0];
		}
	}

	public void Mode1()
	{
		SceneManager.LoadScene("Mode1");
	}

	//switch mute button on and off
	public void ButtonMute()
	{
		SoundManager.Instance.MuteSound();
		if(SoundManager.Instance.music.mute == true)
		{
			buttonMute.image.sprite = spriteMute[1];
		}
		else{
			buttonMute.image.sprite = spriteMute[0];
		}
	}

}
