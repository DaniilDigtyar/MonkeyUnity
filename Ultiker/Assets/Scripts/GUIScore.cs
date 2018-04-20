using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScore : MonoBehaviour {

	public GUIStyle scoreGUI;
	public GUIStyle lifesGUI;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.Label(new Rect (10,Screen.height/100 * 40,200,100),"Punts: " + Globals.puntos.ToString() ,scoreGUI);
		GUI.Label(new Rect (10,Screen.height/100 * 48,200,100),"Vides: " + Globals.vidas.ToString() ,lifesGUI);		
	}



}
