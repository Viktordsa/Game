using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    // Метод для добавления здоровья
    public void AddHealth(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    // Метод для перезапуска добавления здоровья
    public void RestartHealth()
    {
        currentHealth = maxHealth;
    }
}