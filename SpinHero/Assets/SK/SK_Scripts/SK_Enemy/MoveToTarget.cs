using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public bool isStiff;
    [SerializeField] float speed;
    public float attackRange;

    void Update()
    {
        if (isStiff) return;
        Move();
    }
    private void Move()
    {
        if (Vector3.Distance(transform.position, PlayerManager.Instance.Player.position) > attackRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerManager.Instance.Player.position, speed * Time.deltaTime);
        }
    }
}
