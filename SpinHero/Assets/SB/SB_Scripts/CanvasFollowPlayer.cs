using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject followPlayer;

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
}
