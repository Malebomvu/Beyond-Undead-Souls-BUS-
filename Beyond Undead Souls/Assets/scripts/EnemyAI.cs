using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : Enemy
{
    public NavMeshAgent agent;
    public float lookRadius = 15f;
    public Transform Player;

    private void Start()
    { 
        agent = GetComponent<NavMeshAgent>();
       
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        float distance = Vector3.Distance(Player.position, transform.position);
        if (distance <= lookRadius)
        { 
            agent.SetDestination(Player.position);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.purple;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
