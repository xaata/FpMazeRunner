using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    void Start()
    {
        Instantiate(player, transform);
        
    }
}
