using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Rigidbody2D rb2d;
    public Rigidbody2D rb2d_parent;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2d.position = new Vector2 (rb2d_parent.position.x , rb2d.position.y);
    }
}
