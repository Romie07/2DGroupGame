using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField]
    float health = 8;
    float maxHealth;
    void Start()
    {
        maxHealth = health;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}

