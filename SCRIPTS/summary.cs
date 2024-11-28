using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //How to open NavMesh ? -> windows->AI->NavMesh
        //When you change your terrain -> hit BAKE again in NavMesh agent
        //we added 'NavMeshAgent' on Player.
        //how to call NavMesh/use it ->  GetComponent<NavMeshAgent>()
        //Get NavMeshAgent and set the destination to the target's position->>GetComponent<NavMeshAgent>().destination = target.position;
        //you should make all objects 'static' in the inspector if u want the NavMesh to treat it as one
        // i.e. it will create a boundary along 
        //that object and player will not be able to enter it.
        //you can undo 'static' if you want it to be touchable etc.
        //If u assign NavMeshObstacle to an object, the player will avoid it.
        //
        //Settings in NavMesh
        //Radius - Increasing it leaves lesser space for exploration
        //Slope - Decreasing it and player won't be able to climb most slopes ,increase it if you want it to climb most slopes 
        //and avoid only very steep slopes
        //Advanced : Manual voxel size - again increasing this decreases area of exploration.
        //Min Region Area - this will ensure very small areas are avoided and non playable.
        //Speed of player can be controlled either by code or by changing speed of its NavMeshAgent component in the inspector.



    }

}
