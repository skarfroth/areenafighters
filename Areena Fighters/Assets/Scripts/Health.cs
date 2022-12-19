using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            DoDeathStuff();
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }

    private void DoDeathStuff()
    {
        this.gameObject.SetActive(false);
    }
}
