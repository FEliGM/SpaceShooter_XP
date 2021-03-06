﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float timeBetweenSpawns = 1f;
    float leftLimit;
    float rightLimit;
    float bottomLimit;
    float topLimit;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, timeBetweenSpawns);
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
        bottomLimit = bottomLeft.y;
        leftLimit = bottomLeft.x;

        Vector3 topRight = Camera.main.ViewportToWorldPoint(Vector3.one);
        topLimit = topRight.y;
        rightLimit = topRight.x;
    }

    void Spawn()
    {
        float x = Random.Range(leftLimit, rightLimit);
        Vector3 position = new Vector3(x, transform.position.y, 0f);

        int random = Random.Range(0, prefabs.Length);

        Instantiate(prefabs[random], position, Quaternion.identity);
    }


}
