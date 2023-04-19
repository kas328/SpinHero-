using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum WeaponType
{
    blade,
    hammer,
    knife
}

public class WeaponManager : MonoBehaviour
{

    [SerializeField] WeaponType weaponType;
    static WeaponManager instance;

    public static WeaponManager Instance => instance;
    public WeaponType WeaponType { get => weaponType; set => weaponType = value; }

    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
}
