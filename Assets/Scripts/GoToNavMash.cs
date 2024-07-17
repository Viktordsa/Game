using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToNavMash : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    
    void Start()
    {
        target = Player.instance.transform;
        agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
        agent.destination = target.position;

    }
}
