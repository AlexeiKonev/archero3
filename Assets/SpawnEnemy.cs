using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform enemy1;
    public Transform enemy2;

    public Transform[] spawnPool;
    void Start()
    {

        DoSpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoSpawnEnemy()
    {
        enemy1.transform.position = spawnPool[Random.Range(0, spawnPool.Length - 1 )].position;
        enemy1.gameObject.SetActive(true);
    }
}
