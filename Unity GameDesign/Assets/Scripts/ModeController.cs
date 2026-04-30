using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeController : MonoBehaviour
{
    public Sprite[] spriteMute;
	public Button buttonMute;
	public Button buttonInfo;
	public Button buttonReturn;
    
    public static SoundManager Instance {get; set;}

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

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

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
