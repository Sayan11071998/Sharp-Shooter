using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float spped = 30f;
    [SerializeField] private GameObject projectileHitVFXPrefab;

    private Rigidbody rb;
    private int damage;

    private void Awake() => rb = GetComponent<Rigidbody>();

    private void Start() => rb.linearVelocity = transform.forward * spped;

    public void Init(int damage) => this.damage = damage;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        playerHealth?.TakeDamage(damage);
        Instantiate(projectileHitVFXPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}