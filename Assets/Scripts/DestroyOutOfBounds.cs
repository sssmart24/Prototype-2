using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 35;
    private float lowerBound  = -10;
    private float sideBounds = 40;

    GameManager GameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update() 
    {
        if (transform.position.z > topBound)
		{
			Destroy(gameObject);
		} else if (transform.position.z < lowerBound)
		{
            //** Pass an integer in the method below that reduces your player's life **//
			GameManagerScript.UpdateLives(-1);
			Destroy(gameObject);
		}

         //** Uncomment the if statement below once the sideBound variables are declared **//
		if (transform.position.x < -sideBounds || transform.position.x > sideBounds )
		{
			GameManagerScript.UpdateLives(-1);
			Destroy(gameObject);
		}


    }
} 