using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
    public AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();
    }

    public void ButtonInstruccions()
    {
        if (!Globals.muted)
            click.Play();
        Invoke("Instruccions", 0.5f);
    }
    public void Instruccions()
    {
        Application.LoadLevel("MenuInstrucciones");
    }

    public void ButtonAutors()
    {
        if (!Globals.muted)
            click.Play();
        Invoke("Autors", 0.5f);
    }
    public void Autors()
    {
        Application.LoadLevel("MenuAutors");
    }

    public void ButtonMenu()
    {
        if (!Globals.muted)
            click.Play();
        Invoke("Menu", 0.5f);
    }
    public void Menu()
    {
        Application.LoadLevel("MenuPrincipal");
    }

    public void ButtonPlay()
    {
        if (!Globals.muted)
            click.Play();
        Invoke("Play",0.5f);
    }
    public void Play()
    {
        Globals.puntos = 0;
        Globals.vidas = 3;
        Globals.actualLevel = 1;
        Application.LoadLevel("Level1");
    }
}
