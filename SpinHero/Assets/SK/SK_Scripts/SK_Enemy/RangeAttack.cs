using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
    MoveToTarget moveToTarget;
    [SerializeField] GameObject projectile;
    [SerializeField] Transform firePos;
    [SerializeField] float delayTime;
    float currentTime;
    // Start is called before the first frame update

    private void Awake()
    {
        moveToTarget = GetComponent<MoveToTarget>();
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (Vector3.Distance(transform.position, PlayerManager.Instance.Player.position) <= moveToTarget.attackRange)
        {
            if (currentTime <= 0)
            {                
                GameObject projectileObj = Instantiate(projectile);
                projectileObj.transform.position = firePos.position;
                projectileObj.transform.up = PlayerManager.Instance.Player.position - transform.position;
                currentTime = delayTime;
            }
        }
    }
}

