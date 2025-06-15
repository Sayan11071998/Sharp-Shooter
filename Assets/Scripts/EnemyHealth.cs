using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject robotExplosionVFX;
    [SerializeField] private int startingHealth = 3;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}