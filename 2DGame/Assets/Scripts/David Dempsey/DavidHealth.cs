using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DavidHealth : MonoBehaviour
{
    [SerializeField]
    float health = 3f;
    float maxHealth;
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
        
    }
}
