using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject spawnObject;
    public Vector3 spawnPoint;
    public int maxX;
    public int minX;
    public int maxZ;
    public int minZ;
    int x = 0;
    int z = 0;
    public int timeTilNextSpawn = 5;
    float timer = 0;

    void Start()
    {
        timer = 0;
        spawnPoint.x = x;
        spawnPoint.z = z;

    }

    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            x = Random.Range(minZ, maxX);
            spawnPoint.x = x;
            z = Random.Range(minZ, maxZ);
            spawnPoint.z = z;
            Instantiate(spawnObject, spawnPoint, Quaternion.identity);
            timer = 0;
        }

    }

}