using Cinemachine;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private int startingHealth = 5;
    [SerializeField] private CinemachineVirtualCamera deathVirtualCamera;
    [SerializeField] private Transform weaponCamera;
    [SerializeField] private Image[] shieldBars;

    private int currentHealth;
    private int gameOverVirtualCameraPriority = 20;

    private void Awake()
    {
        currentHealth = startingHealth;
        AdjustShieldUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        AdjustShieldUI();

        if (currentHealth <= 0)
        {
            weaponCamera.parent = null;
            deathVirtualCamera.Priority = gameOverVirtualCameraPriority;
            Destroy(this.gameObject);
        }
    }

    private void AdjustShieldUI()
    {
        for (int i = 0; i < shieldBars.Length; i++)
        {
            if (i < currentHealth)
            {
                shieldBars[i].gameObject.SetActive(true);
            }
            else
            {
                shieldBars[i].gameObject.SetActive(false);
            }
        }
    }
}