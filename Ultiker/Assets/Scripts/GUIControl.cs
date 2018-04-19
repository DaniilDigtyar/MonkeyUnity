using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIControl : MonoBehaviour {

	public GUIStyle scoreGUI;
	public GUIStyle lifesGUI;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.Label(new Rect (10,5,200,100),"Punts: " + Globals.puntos.ToString() ,scoreGUI);
		GUI.Label(new Rect (Screen.width - 210, 5,200,100),"Vides: " + Globals.vidas.ToString() ,lifesGUI);		
	}
}
