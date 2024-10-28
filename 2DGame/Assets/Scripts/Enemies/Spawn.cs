using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject zombiePrefab;
    [SerializeField]
    float detectionRadius = 40f;
    [SerializeField]
    int maxNumofZ = 24;
    int Zombies;
    [SerializeField]
    float spawnInterval = 2f;
    float spawnTimer;
    GameObject player;

    void Start()
    {
        spawnTimer = spawnInterval;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        spawnInterval -= Time.deltaTime;

        Vector3 distance = player.transform.position - transform.position;

        countZombies();

        if (Zombies < maxNumofZ && spawnInterval <= 0 && distance.magnitude <= detectionRadius)
        {
            GameObject Zombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            spawnInterval = spawnTimer;
        }
    }

    private void countZombies()
    {
        GameObject[] ZombNum = GameObject.FindGameObjectsWithTag("Zombie");
        Zombies = ZombNum.Length;
    }
}
