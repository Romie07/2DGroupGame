using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField]
    int startingHealth;
    int currentHealth;
    int maxHealth;
    GameObject roundHandler;
    [SerializeField]
    int zhealthDebug;

    private Rounds rounds;

    void Start()
    {
        roundHandler = GameObject.FindGameObjectWithTag("RoundHandler");
        rounds = roundHandler.GetComponent<Rounds>();
        if (rounds.roundNum == 1)
        {
            maxHealth = startingHealth;
        }
        else if (rounds.roundNum > 1)
        {
            maxHealth = Mathf.CeilToInt(startingHealth + (rounds.roundNum - 1) * rounds.getHealthAdd());
        }
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        zhealthDebug = currentHealth;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            currentHealth -= 1;
            if (currentHealth <= 0)
            {
                rounds.zombiesKilled++;
                rounds.totalZombieKills++;
                rounds.zombiesLeft--;
                Destroy(gameObject);
            }
        }

    }
}

