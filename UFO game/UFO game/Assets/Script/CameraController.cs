﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Default camera controller from tutorial
public class CameraController : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
        // the offset is used to move camera first to the player position, then to the camera original position
    }
}
