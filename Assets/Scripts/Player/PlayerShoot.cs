using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    PlayerControls controls;
    public Animator animator;

    [SerializeField] private AudioSource shootSound;

    public GameObject bullet;
    public Transform bulletHole;
    public float velocity = 200;

   

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();


        controls.Terrain.Shoot.performed += ctx => Shoot();
    }

    private void Shoot()
    {
        animator.SetTrigger("shoot");
        GameObject go = Instantiate(bullet, bulletHole.position, bullet.transform.rotation);
        shootSound.Play();
        if(GetComponent<PlayerMovement>().facingDirectionRight)
        {
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.right * velocity);
        }else
        {
            go.GetComponent<Rigidbody2D>().AddForce(Vector2.left * velocity);
        }
    }
   
}
