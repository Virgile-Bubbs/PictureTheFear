using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] targets;
    private NavMeshAgent agent;

    private Transform currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(targets[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform t in targets)
        {
            if(transform.position == t.position)
            {
                NewDestination();
            }
        }
    }

    void NewDestination()
    {
        int indice;
        do
        {
            indice = Random.Range(0, targets.Length - 1);
        }
        while (targets[indice] == currentTarget);
        currentTarget = targets[indice];

        agent.SetDestination(currentTarget.position);
    }
}
