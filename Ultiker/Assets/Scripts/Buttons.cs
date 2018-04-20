using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public void ButtonInstruccions()
    {
        Invoke("Instruccions", 0.5f);
    }
    public void Instruccions()
    {
        Application.LoadLevel("MenuInstrucciones");
    }

    public void ButtonAutors()
    {
        Invoke("Autors", 0.5f);
    }
    public void Autors()
    {
        Application.LoadLevel("MenuAutors");
    }

    public void ButtonMenu()
    {
        Invoke("Menu", 0.5f);
    }
    public void Menu()
    {
        Application.LoadLevel("MenuPrincipal");
    }

    public void ButtonPlay()
    {
        Invoke("Play",0.5f);
    }
    public void Play()
    {
        Globals.puntos = 0;
        Globals.vidas = 3;
        Application.LoadLevel("Level1");
    }
}
