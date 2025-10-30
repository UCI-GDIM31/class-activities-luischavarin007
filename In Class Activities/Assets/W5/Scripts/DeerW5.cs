using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

//What member variable(s) does this class need?
//There will need to be a member variable for the transform the deer needs to go to and a member variable that tells the deer to go to this destination.

//What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
//The deer will not read the player's inputs, so Update() should not be needed. The method will also need [SerializeField] in order for it to show up as a component in the inspector.

//What should the method(s) do?
//The method should be able to manipulate the NavMeshAgent component to have the deer transform to the intended location.

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _destination;


     private void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(_destination.position);
    }
}