using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk_Attack : StateMachineBehaviour
{
    Transform target;

    Transform borderCheck;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        borderCheck = animator.GetComponent<TrunkMediumEnemy>().borderCheck;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Physics2D.Raycast(borderCheck.position, Vector2.down, 2) == false)
        {
            animator.SetBool("isNearToAtack", false);
        }

        float distance = Vector2.Distance(target.position, animator.transform.position);

        if(distance > 10)
        {
            animator.SetBool("isNearToAtack", false);
            animator.SetBool("isNear", true);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
