using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    [SerializeField] WeaponType weaponType;
    private void Awake()
    {
        gameObject.SetActive(weaponType == WeaponManager.Instance.WeaponType);
    }
}
