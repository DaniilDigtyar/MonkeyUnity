using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {
    private static SoundControl _instance;
    private AudioSource audio;

    void Awake()
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
        if (Input.GetKeyUp(KeyCode.M) && Globals.muted == false)
        {
            print("Sound Muted");
            audio.Pause();
            Globals.muted = true;
        }
        else if(Input.GetKeyUp(KeyCode.M) && Globals.muted == true)
        {
            print("Sound Unmuted");
            audio.UnPause();
            Globals.muted = false;
        }
    }

}

