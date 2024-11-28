using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    // We deleted start method.This will create a field in Inspector where you can put an object....
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        //Get NavMeshAgent and set the destination to the target's position.
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
