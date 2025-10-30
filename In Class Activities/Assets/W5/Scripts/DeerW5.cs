using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;




public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _destination;


     private void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(_destination.position);
    }
}