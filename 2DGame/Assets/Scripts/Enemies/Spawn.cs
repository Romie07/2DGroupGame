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
    int Zombies;
    [SerializeField]
    float spawnInterval = 2f;
    float spawnTimer;
    GameObject player;
    GameObject roundHandler;
    int maxNumofZ;

    private Rounds rounds;
    void Start()
    {
        roundHandler = GameObject.FindGameObjectWithTag("RoundHandler");
        rounds = roundHandler.GetComponent<Rounds>();
        spawnTimer = spawnInterval;
        player = GameObject.FindGameObjectWithTag("Player");
        maxNumofZ = rounds.zombieAmt();
    }

    void Update()
    {
        maxNumofZ = rounds.zombieAmt();
        spawnTimer -= Time.deltaTime;

        Vector3 distance = player.transform.position - transform.position;

        countZombies();

        if (Zombies < maxNumofZ && spawnTimer <= 0 && distance.magnitude <= detectionRadius)
        {
            GameObject Zombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            spawnTimer = spawnInterval;
            maxNumofZ--;
        }
    }

    private void countZombies()
    {
        GameObject[] ZombNum = GameObject.FindGameObjectsWithTag("Zombie");
        Zombies = ZombNum.Length;
    }
}
