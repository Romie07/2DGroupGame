using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float chaseSpeed = 5f;
    [SerializeField]
    float detectionRadius = 10f;
    [SerializeField]
    float hesitate = 2f;
    float hesitateTimer;
    Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDir = playerPosition - transform.position;
        if (chaseDir.magnitude < detectionRadius)
        {
            //chase the player
            //chase direction = players position - my current position
            //move in the direction of the player
            chaseDir.Normalize();
            rb.velocity = chaseDir * chaseSpeed;
            hesitateTimer = 0;
        }
    }
}
