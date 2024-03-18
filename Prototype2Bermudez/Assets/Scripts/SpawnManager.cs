using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }      
    }
       void SpawnRandomAnimal()
       { 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20) spawnpos, 
        animalPrefabs[animalIndex].transform.rotation);
       }

}

