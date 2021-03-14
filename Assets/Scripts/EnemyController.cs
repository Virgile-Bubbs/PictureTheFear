using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] targets;
    private NavMeshAgent agent;
    private Animator animator;

    private Transform currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        animator.SetBool("isWalking", true);
        NewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = new Vector3((int)transform.position.x, (int)transform.position.y, (int)transform.position.z);
        Vector3 targetPosition = new Vector3((int)currentTarget.position.x, (int)currentTarget.position.y, (int)currentTarget.position.z);

        if(currentPosition == targetPosition)
        {
            NewDestination();
        }

    }

    void NewDestination()
    {
        int indice;
        do
        {
            indice = Random.Range(0, targets.Length);
        }
        while (targets[indice] == currentTarget);
        currentTarget = targets[indice];

        agent.SetDestination(currentTarget.position);
    }
}
