using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Threading;

public class SpawnerScript : MonoBehaviour
{
    public float spawnRadius = 3f;
    public GameObject[] prefabs;
    //public GameObject prefabEnemy;
    //public GameObject prefabBlueEnemy;
    public float spawnRate = 1f;
    public float spawnFactor = 0f;
    public float time = 60f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(gameObject.transform.position, spawnRadius);
    }

    void Update()
    {
        HandleSpawn();
    }

    void HandleSpawn()
    {
        spawnFactor += Time.deltaTime;
        if (spawnFactor >= spawnRate)
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            Spawn(prefabs[randomIndex]);
            spawnFactor = 0;
        }
    }

    //void HandleSpawn()
    //{
    //    spawnFactor += Time.deltaTime;
    //    if (spawnFactor >= spawnRate)
    //    {
    //        spawnFactor = 0;
    //    }
    //    if (time >= 60f)
    //    {
    //        Instantiate(prefabBlueEnemy);
    //    }
    //}


    void Spawn(GameObject gO)
    {
        GameObject newObject = Instantiate(gO);
        Vector3 randomPoint = Random.insideUnitSphere * spawnRadius;
        newObject.transform.position = transform.position + randomPoint;
    }
}
