using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddmobToggle : MonoBehaviour
{
    public bool isToggle;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        AddmobManager.Instance.ToggleBannerAd(isToggle);
    }
}
