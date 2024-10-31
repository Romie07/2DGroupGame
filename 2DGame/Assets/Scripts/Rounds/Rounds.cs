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
    public float zombieSpawnCooldown = 5f;
    [SerializeField]
    float roundChangeCooldown = 10f;
    [SerializeField]
    TMP_Text roundCount;
    [Header("Round Increase Settings")]
    [SerializeField]
    int healthIncrease = 6;
    [SerializeField]
    float zombieIncreaseMultiplier = 1.25f;
    int currentRoundZombieMax;
    float timer;
    [Header("Sound")]
    [SerializeField]
    AudioSource roundStart;
    [Header("Testing")]
    public float roundNum;
    public int zombiesKilled;
    public int zombiesLeft;
    public int totalZombieKills;
    public float Cooldown = 10f;

    void Start()
    {
        roundStart = GetComponent<AudioSource>();
        currentRound = startOnRound;
        roundCount.text = startOnRound.ToString();
        if (currentRound == 1)
        {
            roundStart.Play();
            Cooldown = roundChangeCooldown;
            currentRoundZombieMax = zombiesOnRoundOne;
            zombiesLeft = currentRoundZombieMax;
            roundNum = currentRound;
        }
        if (currentRound > 1)
        {
            roundStart.Play();
            Cooldown = roundChangeCooldown;
            currentRoundZombieMax = Mathf.CeilToInt(zombiesOnRoundOne * (currentRound * zombieIncreaseMultiplier));
            zombiesLeft = currentRoundZombieMax;
            roundNum = currentRound;
        }
    }

    void Update()
    {
        Cooldown -= Time.deltaTime;
        RoundAdjustments();
    }

    private void RoundAdjustments()
    {
        if (zombiesKilled >= currentRoundZombieMax)
        {
            zombiesKilled = 0;
            currentRound += 1;
            Cooldown = roundChangeCooldown;
            roundStart.Play();
            if (currentRound >= 1 && Cooldown > 5)
            {
                currentRoundZombieMax = Mathf.CeilToInt(zombiesOnRoundOne * (currentRound * zombieIncreaseMultiplier));
                roundNum = currentRound;
            }
            roundCount.text = currentRound.ToString();
            zombiesLeft = currentRoundZombieMax;
        }
    }

    public int getHealthAdd()
    {
        return healthIncrease;
    }

}
