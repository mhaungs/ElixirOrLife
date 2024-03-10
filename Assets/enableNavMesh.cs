using UnityEngine;
using UnityEngine.AI;

public class EnableNavMesh : StateMachineBehaviour
{
    //public NavMeshAgent navMeshAgent; // Reference to the NavMeshSurface component
    //public droneAgent dragonBehavior; // Reference to the script controlling dragon behavior

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // // Activate NavMeshAgent
        // if (navMeshAgent != null)
        // {
        //     navMeshAgent.enabled = true;
        // }

        // // Activate Dragon Behavior Script
        // if (dragonBehavior != null)
        // {
        //     dragonBehavior.enabled = true;
        // }

        // Find the GameObject with the tag "DragonComplete"
        GameObject dragon = GameObject.FindGameObjectWithTag("DragonComplete");

        // If a dragon is found
        if (dragon != null)
        {
            // Get the NavMeshAgent component and enable it
            NavMeshAgent navMeshAgent = dragon.GetComponent<NavMeshAgent>();
            if (navMeshAgent != null)
            {
                navMeshAgent.enabled = true;
            }

            // Get the DroneAgent script component and enable it
            droneAgent droneAgent = dragon.GetComponent<droneAgent>();
            if (droneAgent != null)
            {
                droneAgent.enabled = true;
            }
        }
        else
        {
            Debug.LogWarning("No dragon found with tag 'DragonComplete'");
        }
    
    }
}
