using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rounds : MonoBehaviour
{
    [Header("General")]
    [SerializeField]
    float startOnRound = 1;
    float currentRound;
    [SerializeField]
    int zombiesOnRoundOne = 8;
    int currentZombies;
    [SerializeField]
    TMP_Text roundCount;
    [Header("Round Increase Settings")]
    [SerializeField]
    float healthIncreaseMultiplier = 1;
    [SerializeField]
    float zombieIncreaseMultiplier = 1.25f;
    int currentRoundZombieMax;
    [SerializeField]
    float timeBetweenRounds;
    float timer;
    [Header("Sound")]
    [SerializeField]
    AudioClip roundStart;
    

    void Start()
    {
        currentRound = startOnRound;
        roundCount.text = startOnRound.ToString();
        
    }

    void Update()
    {
        if (currentRound == 1)
        {
            currentRoundZombieMax = zombiesOnRoundOne;
        }
        else
        {
            currentRoundZombieMax = Mathf.RoundToInt(zombiesOnRoundOne * (currentRound * zombieIncreaseMultiplier));
        }
        checkForZombies();
    }

    private void checkForZombies()
    {
        currentZombies = GameObject.FindGameObjectsWithTag("Zombie").Length;
    }
    private void RoundAdjustments()
    {
        if (currentZombies == 0)
        {
            currentRound += 1;
        }
    }

    public int zombieAmt()
    {
        return currentRoundZombieMax;
    }

}
