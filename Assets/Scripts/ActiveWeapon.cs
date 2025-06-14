using StarterAssets;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] private WeaponSO weaponSO;

    private Animator animator;
    private StarterAssetsInputs starterAssetsInputs;
    private Weapon currentWeapon;

    private const string SHOOT_STRING = "Shoot";

    private float timeSinceLastShot = 0f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }

    private void Start()
    {
        currentWeapon = GetComponentInChildren<Weapon>();
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        HandleShoot();
    }

    private void HandleShoot()
    {
        if (!starterAssetsInputs.shoot) return;

        if (timeSinceLastShot >= weaponSO.fireRate)
        {
            currentWeapon.Shoot(weaponSO);
            animator.Play(SHOOT_STRING, 0, 0f);
            timeSinceLastShot = 0f;
        }

        starterAssetsInputs.ShootInput(false);
    }
}