using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth = 100;

    public void AddHealth(int amount)
    {
        currentHealth += amount;
        Debug.Log("Health increased by: " + amount + ". Current Health: " + currentHealth);
    }
}