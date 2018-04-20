using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

	public GUIStyle Paused;
	private bool showPause;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
		{
			//si el joc no esta pausat, es pausa (la musica tambe)
			if (!Globals.paused)
			{
				showPause = true;
				Globals.paused = true;
				SoundControl.PauseSound();
				Time.timeScale = 0;
			}
			//si el joc ja estava pausat, es reanuda i, en cas de tenir el so actiivat, continuara la musica 
			else
			{
				showPause = false;
				Time.timeScale = 1;
				SoundControl.UnPauseSound();
				Globals.paused = false;
			}
			
		}
	}

	void OnGUI(){
		if (showPause)
			GUI.Label(new Rect (Screen.width/2,Screen.height/2,200,100),"Paused" ,Paused);	
	}
}
