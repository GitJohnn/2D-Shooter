using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    //GameManager is GM
    bool GM;

    public float maxY;
    public float maxX;

    private float spawnRate;
    public float startSpawnRate;

    private void Awake()
    {
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().game;
        spawnRate = startSpawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        //Update the bool variable
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().game;
        if (spawnRate <= 0 && GM)
        {
            SpawnEnemiesLocation();
            spawnRate = startSpawnRate;
        }
        else
        {
            spawnRate -= Time.deltaTime;
        }

        if (!GM)
        {
            DestroyEnemies();
        }

    }

    void DestroyEnemies()
    {
        GameObject[] destroyEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        
        for(int i = 0; i < destroyEnemy.Length; i++)
        {
            Destroy(destroyEnemy[i]);
        }
    }

    void SpawnEnemiesLocation()
    {
        float spawnY = Random.Range(-maxY, maxY);
        float spawnX = Random.Range(-maxX, maxX);

        Instantiate(enemy, new Vector3(spawnX,spawnY,0), Quaternion.identity);

    }
}
