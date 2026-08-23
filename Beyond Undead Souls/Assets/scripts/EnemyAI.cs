using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : Enemy
{
    public NavMeshAgent agent;
    public float lookRadius = 10f;
    public Transform target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = transform;
    }
    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        { 
            agent.transform.position = target.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.purple;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
