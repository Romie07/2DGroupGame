using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DavidHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField]
    public float playerHealth = 3f;
    float maxHealth;
    [Header("Regen")]
    [SerializeField]
    float regenSpeed = 2f;
    float regenAmount = 1f;
    float regenTimer;

    void Start()
    {
        maxHealth = playerHealth;
    }

    private void Update()
    {
        regenTimer += Time.deltaTime;
    }

    public void TakeDamage(float amount)
    {
        playerHealth -= amount;
        if (playerHealth < maxHealth && regenTimer > regenSpeed)
        {
            Regen();
        }

        else if (playerHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Regen()
    {
        playerHealth += regenAmount;
        regenTimer = 0;
    }
   
}
