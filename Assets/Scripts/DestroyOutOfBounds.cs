﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 35;
    private float lowerBound  = -10;
    private float sideBound = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    if(transform.position.z > topBound ||transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound )
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
} 