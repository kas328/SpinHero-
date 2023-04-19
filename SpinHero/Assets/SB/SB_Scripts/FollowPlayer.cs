using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Target; 
    public float Speed = 0.2f;
    private void Start()
    {
        Target = GameObject.Find("Player").transform;
    }
    void Update() { 
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime); 
    }
}
