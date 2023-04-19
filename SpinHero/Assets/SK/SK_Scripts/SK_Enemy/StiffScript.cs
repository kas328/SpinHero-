using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StiffScript : MonoBehaviour
{
    MoveToTarget moveToTarget;
    float stiffTime = 1;

    private void Awake()
    {
        moveToTarget = GetComponent<MoveToTarget>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (moveToTarget.isStiff == false)
            {
                StartCoroutine(WaitTime());
            }
        }
    }
    IEnumerator WaitTime()
    {
        moveToTarget.isStiff = true;
        yield return new WaitForSeconds(stiffTime);
        moveToTarget.isStiff = false;
    }
}
