using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    float randomX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-0.4f, 0.4f);
            whereToSpawn = new Vector2(randomX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.Identity);
        }
        
    }
}
