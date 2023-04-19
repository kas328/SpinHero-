using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyObjs;
    public Transform[] spawnPoints;
    public Transform container;

    public float maxSpawnDelay;
    public float curSpawnDelay;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        
        if(curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, enemyObjs.Length);
        int ranPoint = Random.Range(0, spawnPoints.Length);

        //Instantiate(enemyObjs[ranEnemy], spawnPoints[ranPoint].position, Quaternion.identity);
        GameObject enemy = JHS.PoolManager.Instance.PopObject(enemyObjs[ranEnemy]);
        enemy.transform.position = spawnPoints[ranPoint].position;
        enemy.transform.SetParent(container);
        enemy.transform.localScale = Vector3.one * 0.3f;

    }
}
