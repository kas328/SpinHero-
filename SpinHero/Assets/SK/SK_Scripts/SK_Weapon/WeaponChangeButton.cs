using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChangeButton : MonoBehaviour
{
    [SerializeField] WeaponType weaponType;

    public void ChangeWeapon()
    {
        WeaponManager.Instance.WeaponType = weaponType;
    }
}
