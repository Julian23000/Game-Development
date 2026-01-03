using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{

    public Transform Zombie;
    public float runaway = 10f;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Vector3 directionAway = transform.position - Zombie.position;
        Vector3 targetPosition = transform.position + directionAway.normalized * runaway;

        agent.SetDestination(targetPosition);
    }

}
