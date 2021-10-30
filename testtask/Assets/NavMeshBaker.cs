using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshBaker : MonoBehaviour
{
    public GameObject floor;
    public void Start()
    {
       GetComponent<NavMeshSurface>().BuildNavMesh();
    }
}
