using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnAnimals : MonoBehaviour
{

    public GameObject[] animals;
    
    private float spawnRangeXStart;
    private float spawnRangeXEnd;
    
    
    private float startDelayFriendly;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnRangeXStart = -20f;
        spawnRangeXEnd = 20f;
        startDelayFriendly = 2f;
        Invoke("SpawnFriendlyAnimals", startDelayFriendly);
    }

    void SpawnFriendlyAnimals()
    {
        startDelayFriendly = Random.Range(1, 3);
        int randomIndexAnimal = Random.Range(0, animals.Length);
        Vector3 spawnLocation = new Vector3(Random.Range(spawnRangeXStart, spawnRangeXEnd), 0, 23);
        Instantiate(animals[randomIndexAnimal], spawnLocation, animals[randomIndexAnimal].transform.rotation);
        Invoke("SpawnFriendlyAnimals", startDelayFriendly);
    }
}
