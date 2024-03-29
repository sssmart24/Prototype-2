﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomAnimal", startDelay, spawnInterval);
    }
   

    // Update is called once per frame
    void Update()
    {
         
    }

        void SpawnRandomAnimal() 
        {
                int animalIndex = Random.Range(0, animalPrefabs.Length);
                Vector3 spawnpos = new Vector3(Random.Range (-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                Vector3 spawnposZ = new Vector3(-22, 0, Random.Range(-4,12));
                //randomly generate animal index and spawn position//
                Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
                Instantiate(animalPrefabs[animalIndex], spawnposZ, animalPrefabs[animalIndex].transform.rotation);
        }
}