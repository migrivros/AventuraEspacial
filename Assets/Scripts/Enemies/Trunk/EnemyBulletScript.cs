using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rigidbody;

    [SerializeField] private AudioSource deathSoundEffect;

    public float force;

    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
       player = GameObject.FindGameObjectWithTag("Player"); 

       Vector3 direction = player.transform.position - transform.position;
       rigidbody.velocity = new Vector2(direction.x, direction.y+0.5f).normalized * force;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Trap" || collision.tag == "Terrain")
        {
            Destroy(gameObject);
        }
        if(collision.tag == "Player")
        {
            HealthManager.playerHealth = HealthManager.playerHealth - 3;
            if(HealthManager.playerHealth <= 0)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false; // Para poder invisibilizar la bala sin eliminar el objeto (y poder reproducir el audio)
                PlayerManager.isGameOver = true;
                deathSoundEffect.Play();
                player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                player.GetComponent<Animator>().SetTrigger("death");
            }
        }
    }
}
