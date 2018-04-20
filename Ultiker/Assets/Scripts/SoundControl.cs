using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {
    private static SoundControl _instance;
    private static AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        //if we don't have an [_instance] set yet
        if (!_instance)
        {
            _instance = this;
            audio.Play();
        }

        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.M) && !Globals.muted && !Globals.paused )
        {
			PauseSound();
        }
        else if(Input.GetKeyUp(KeyCode.M) && Globals.muted && !Globals.paused )
        {
			UnPauseSound();
        }
    }



	public static void PauseSound(){
		audio.Pause();
		Globals.muted = true;
	}

	public static void UnPauseSound(){
		audio.UnPause();
		Globals.muted = false;
	}


}

