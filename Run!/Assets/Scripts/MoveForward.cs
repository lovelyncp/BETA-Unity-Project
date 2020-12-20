﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 15.0f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // player controller when game over is false
        if(playerControllerScript.gameover == false)
        {
            // move player
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
