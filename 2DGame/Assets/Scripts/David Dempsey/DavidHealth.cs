using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField]
    float health = 3f;
    float maxHealth;
    [Header("Regen")]
    [SerializeField]
    float regenSpeed = 2f;
    float regenAmount = 1f;
    float regenTimer;

    void Start()
    {
        maxHealth = health;
    }


    void Update()
    {
        if (health <=0)
        {
            Debug.Log("You died");
        }
    }
}
