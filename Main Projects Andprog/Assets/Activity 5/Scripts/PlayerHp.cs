using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar playerHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        playerHealth.UpdateHealth(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Im dead");
            GameManager.Instance.GameLose();
        }
    }

    void Update()
    {
        
    }
}
