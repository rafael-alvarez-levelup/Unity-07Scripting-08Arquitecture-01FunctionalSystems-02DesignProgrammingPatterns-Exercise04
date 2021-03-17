using UnityEngine;

//TOOD: Implement heal and take damage

public class HealthBehaviour : MonoBehaviour, IHealth
{
    [SerializeField] private int maxHealth;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public void Heal(int amount)
    {

    }

    public void TakeDamage(int amount)
    {

    }
}