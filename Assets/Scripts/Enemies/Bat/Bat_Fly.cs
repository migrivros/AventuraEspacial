using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_Fly : StateMachineBehaviour
{
    Transform target;
    public float speed = 1;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 newPosition = new Vector2(target.position.x, target.position.y+1);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, newPosition, speed * Time.deltaTime);

        float distance = Vector2.Distance(target.position, animator.transform.position);

        if(distance < 8)
        {
            animator.SetBool("isNear", false);
            animator.SetBool("isNearToAtack", true);
        }

        if(distance > 15)
        {
            animator.SetBool("isNear", false);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
