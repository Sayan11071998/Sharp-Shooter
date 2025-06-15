using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform turretHead;
    [SerializeField] private Transform PlayerTargetPoint;
    [SerializeField] private Transform projectileSpawnPoint;
    [SerializeField] private float fireRate = 2f;
    [SerializeField] private int damage = 2;

    private PlayerHealth player;

    private void Start()
    {
        player = FindFirstObjectByType<PlayerHealth>();
        StartCoroutine(FireRoutine());
    }

    private void Update()
    {
        turretHead.LookAt(PlayerTargetPoint.position);
    }

    IEnumerator FireRoutine()
    {
        while (player)
        {
            yield return new WaitForSeconds(fireRate);
            Projectile newProjectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity).GetComponent<Projectile>();
            newProjectile.transform.LookAt(PlayerTargetPoint);
            newProjectile.Init(damage);
        }
    }
}