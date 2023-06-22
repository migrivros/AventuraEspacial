using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja_Run : StateMachineBehaviour
{
    Transform target;
    public float speed = 5f;

    Transform borderCheck;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        borderCheck = animator.GetComponent<NinjaBoss>().borderCheck;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 newPosition = new Vector2(target.position.x, animator.transform.position.y);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, newPosition, speed * Time.deltaTime);

        if(Physics2D.Raycast(borderCheck.position, Vector2.down, 2) == false)
        {
            animator.SetBool("isNearToRun", false);
        }

        float distance = Vector2.Distance(target.position, animator.transform.position);

        if(distance < 3)
        {
            animator.SetBool("isNearToAttack", true);
            animator.SetBool("isNearToRun", false);
        }

        if(distance > 10)
        {
            animator.SetBool("isNearToRun", false);
            animator.SetBool("isNear", true);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioManager.instance.Play("KnightSword");
    }
}
