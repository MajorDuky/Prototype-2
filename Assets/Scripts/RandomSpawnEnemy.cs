using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyAnimals;
    private float spawnRangeZStart;
    private float spawnRangeZEnd;
    private float startDelayEnemy;
    // Start is called before the first frame update
    void Start()
    {
        spawnRangeZStart = 0f;
        spawnRangeZEnd = 15f;
        startDelayEnemy = 2f;
        Invoke("SpawnEnemyAnimals", startDelayEnemy);
    }

    void SpawnEnemyAnimals()
    {
        startDelayEnemy = Random.Range(1, 3);
        int randomIndexAnimal = Random.Range(0, enemyAnimals.Length);
        int randomChoice = Random.Range(0, 2);
        if (randomChoice == 0)
        {
            Vector3 spawnLocation = new Vector3(-20, 0, Random.Range(spawnRangeZStart, spawnRangeZEnd));
            Instantiate(enemyAnimals[randomIndexAnimal], spawnLocation, enemyAnimals[randomIndexAnimal].transform.rotation);
        }
        else
        {
            Vector3 spawnLocation = new Vector3(20, 0, Random.Range(spawnRangeZStart, spawnRangeZEnd));
            GameObject clone = Instantiate(enemyAnimals[randomIndexAnimal], spawnLocation, enemyAnimals[randomIndexAnimal].transform.rotation);
            clone.transform.Rotate(Vector3.up, 180);
        }
        
        
        Invoke("SpawnEnemyAnimals", startDelayEnemy);
    }
}
