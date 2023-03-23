using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Animator animator;

    private AudioSource checkpointSound;

    private void Start()
    {
        animator = GetComponent<Animator>();
        checkpointSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerManager.lastCheckPoint = transform.position;
            checkpointSound.Play();
            animator.SetInteger("state", 1);
        }
    }
}
