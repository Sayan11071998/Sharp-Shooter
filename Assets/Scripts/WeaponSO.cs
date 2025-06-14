using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "Scriptable Objects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject WeappnPrefab;
    public int Damage = 1;
    public float fireRate = 0.5f;
    public GameObject HitVFXPrefab;
    public bool IsAutomatic = false;
}