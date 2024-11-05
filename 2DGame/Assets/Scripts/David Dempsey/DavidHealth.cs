using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DavidHealth : MonoBehaviour
{
    [Header("Health")]
    [SerializeField]
    public int playerHealth = 3;
    public int maxHealth;
    [Header("Regen")]
    [SerializeField]
    float regenSpeed = 2f;
    int regenAmount = 1;
    float regenTimer;
    public bool interact;

    void Start()
    {
        maxHealth = playerHealth;
    }

    private void Update()
    {
        regenTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
        {
                interact = true;

        }
        else
        {
            interact = false;
        }
    }

    public void TakeDamage(int amount)
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
