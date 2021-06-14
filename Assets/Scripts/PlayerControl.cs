﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-5, 0);
            transform.localScale = new Vector2(-1,1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(5, 0);
            transform.localScale = new Vector2(1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);

        }
    }
}
