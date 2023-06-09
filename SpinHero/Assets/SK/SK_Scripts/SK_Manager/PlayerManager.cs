using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] Transform player;
    static PlayerManager instance;

    public static PlayerManager Instance
    {
        get
        {
            if(instance == null) instance = FindObjectOfType<PlayerManager>();

            return instance;
        }
    }

    public Transform Player { get => player; set => player = value; }
}
