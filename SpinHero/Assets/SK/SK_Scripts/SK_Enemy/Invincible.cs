using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("WaitTime");
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        GetComponent<EnemyHP>().CurrentHP = 0;
        //gameObject.layer = LayerMask.NameToLayer("");
    }
}
