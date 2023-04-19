using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        Vector2 projectileMove = Vector2.up * speed * Time.deltaTime;

        transform.Translate(projectileMove);
    }
}
