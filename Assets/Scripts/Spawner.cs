using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private List<Transform> spawnLocations = new List<Transform>();
    [SerializeField] private GameObject[] enemyTypes;
    [SerializeField] private int startTime;
    [SerializeField] private float spawnRate;

    void Start()
    {
        //Add all children transforms as potential spawn locations
        foreach(Transform child in transform)
        {
            spawnLocations.Add(child);
        }
        InvokeRepeating("SpawnEnemy", startTime, spawnRate);
    }


    void SpawnEnemy()
    {
        //Spawns a random enemy type at a random spawn location
        Instantiate(enemyTypes[Random.Range(0, enemyTypes.Length)], spawnLocations[Random.Range(0, spawnLocations.Count)].position, Quaternion.identity);
    }
}
