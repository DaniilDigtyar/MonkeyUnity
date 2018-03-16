using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour {

	public Vector2 inicialDistance;
	public Vector2 finalDistance;
	public Vector2 velocity;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	/// <summary>
	/// Fixeds the update.
	/// </summary>
	void FixedUpdate() {
		PlatformMovment();
	}

	/// <summary>
	/// Funcion que mueve la plataforma en las 4 posiciones.
	/// la distancia incial ha de ser menor que la final
	/// </summary>
	/// <author>Daniil Digtyar</author>
	void PlatformMovment(){
		rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
		if (rb2d.position.x < inicialDistance.x && velocity.x < 0 || rb2d.position.x > finalDistance.x && velocity.x > 0){
			velocity.x = -velocity.x;
		}
		if (rb2d.position.y < inicialDistance.y && velocity.y < 0 || rb2d.position.y > finalDistance.y && velocity.y > 0){
			velocity.y = -velocity.y;
		}
	}
}
