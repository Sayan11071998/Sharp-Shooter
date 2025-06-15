using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject robotExplosionVFX;
    [SerializeField] private int startingHealth = 3;

    private GameManager gameManager;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.AdjustEnemiesLeft(1);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            gameManager.AdjustEnemiesLeft(-1);
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}