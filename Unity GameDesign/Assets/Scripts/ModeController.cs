using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeController : MonoBehaviour
{
    public Sprite[] spriteMute;
	public Button buttonMute;
    
    public static SoundManager Instance {get; set;}

    public AudioSource music;

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
}
