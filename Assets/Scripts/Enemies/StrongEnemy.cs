using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : MonoBehaviour
{

    Transform target;
    float initScale;
    public static int enemyLife = 500;

    public Animator animator;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource damageSoundEffect;

    public Transform borderCheck;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        initScale = transform.localScale.x;
        enemyLife = 500;
        //Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x < transform.position.x) //Para cambiar la direccion de mira del enemigo
        {
            transform.localScale = new Vector2(initScale, transform.localScale.y);
        }
        else
        {
            transform.localScale = new Vector2(-initScale, transform.localScale.y);
        }
    }

    public void TakeDamage(int damage)
    {
        enemyLife -= damage;
        
        if(enemyLife > 0)
        {
            damageSoundEffect.Play();
            animator.SetTrigger("damage");
        }
        else
        {
            deathSoundEffect.Play();
            animator.SetTrigger("death"); 
            GetComponent<CapsuleCollider2D>().enabled = false;
            enemyLife = 500;
            //this.enabled = false;
        }
    }
}
