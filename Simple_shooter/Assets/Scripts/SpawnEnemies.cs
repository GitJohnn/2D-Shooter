using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;

    public float maxY;
    public float maxX;

    private float spawnRate;
    public float startSpawnRate;

    private void Awake()
    {
        spawnRate = startSpawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnRate <= 0)
        {
            SpawnEnemiesLocation();
            spawnRate = startSpawnRate;
        }
        else
        {
            spawnRate -= Time.deltaTime;
        }
    }

    void SpawnEnemiesLocation()
    {
        float spawnY = Random.Range(-maxY, maxY);
        float spawnX = Random.Range(-maxX, maxX);

        Instantiate(enemy, new Vector3(spawnX,spawnY,0), Quaternion.identity);

    }
}
