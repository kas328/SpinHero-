using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSword : MonoBehaviour
{
    [SerializeField] GameObject followPlayer;
    [SerializeField] float rotateSpeed = 680.0f;
    float z;

    void Start()
    {
        StartCoroutine(FollowPlayerCor());
    }

    IEnumerator FollowPlayerCor()
    {
        while (true)
        {
            transform.position = followPlayer.transform.position;
            yield return null;
        }
    }
    void Update()
    {
        z -= Time.deltaTime * rotateSpeed;
        transform.rotation = Quaternion.Euler(0, 0, z);        
    }
}
