using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs; 
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
        Instantiate(ballPrefabs[ballIndex], spawnpos, ballPrefabs[ballIndex], transform.rotation);
        
    }
}
