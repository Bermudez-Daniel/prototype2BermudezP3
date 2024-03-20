using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xSpawnRange = 20;
    private float zSpawnPos = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

     void Start()
    {
       InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
    }
    void Update()
    {
     
    }
        void SpawnRandomAnimal()
        {
        Vector3 SpawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], SpawnPos, animalPrefabs[animalIndex].transform.rotation);
        }

    
}

