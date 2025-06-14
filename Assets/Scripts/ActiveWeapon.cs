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
        HandleShoot();
        HandleZoom();
    }

    public void SwitchWeapon(WeaponSO weaponSO)
    {
        if (currentWeapon)
            Destroy(currentWeapon.gameObject);

        Weapon newWeapon = Instantiate(weaponSO.WeappnPrefab, transform).GetComponent<Weapon>();
        currentWeapon = newWeapon;
        this.weaponSO = weaponSO;
    }

    private void HandleShoot()
    {
        timeSinceLastShot += Time.deltaTime;

        if (!starterAssetsInputs.shoot) return;

        if (timeSinceLastShot >= weaponSO.fireRate)
        {
            currentWeapon.Shoot(weaponSO);
            animator.Play(SHOOT_STRING, 0, 0f);
            timeSinceLastShot = 0f;
        }

        if (!weaponSO.IsAutomatic)
        {
            starterAssetsInputs.ShootInput(false);
        }
    }

    private void HandleZoom()
    {
        if (!weaponSO.CanZoom) return;

        if (starterAssetsInputs.zoom)
        {
            Debug.Log("Zooming in");
        }
        else
        {
            Debug.Log("Not Zooming in");
        }
    }
}