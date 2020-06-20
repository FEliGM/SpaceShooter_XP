using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float timeBetweenSpawn = 1f;

    private void Start()
    {

        InvokeRepeating("Spawn", 1f, timeBetweenSpawn);

    }

    void Spawn()
    {
        float x = Random.Range(-3f, 3f);
        Vector3 position = new Vector3(x, transform.position.y, 0f);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
