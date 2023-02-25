using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        bar.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= maxHealth * 0.5)
        {
            bar.color = new Color(1, 0.5f, 0);
        }

        if (currentHealth <= maxHealth * 0.1)
        {
            bar.color = new Color(1, 0, 0);
        }
    }
}
