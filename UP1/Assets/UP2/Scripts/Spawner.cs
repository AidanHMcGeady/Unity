using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int AnimalIndex;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private float spawnRangeX = 20;
    private float spawnPozZ = 28;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //randomize spawn location
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPozZ);

        //picks random number between 0 and array length
        AnimalIndex = Random.Range(0, animalPrefabs.Length);

        //spawns animal from array at position
        Instantiate(animalPrefabs[AnimalIndex], spawnPos,
            animalPrefabs[AnimalIndex].transform.rotation);
    }
}
