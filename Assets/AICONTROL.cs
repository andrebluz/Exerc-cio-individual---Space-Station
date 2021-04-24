using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICONTROL : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>(); //diz para o objeto que o agent de navmesh é ele próprio
    }
}
