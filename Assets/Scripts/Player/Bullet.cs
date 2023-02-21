using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage = 50;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Trap" || collision.tag == "Terrain")
        {
            Destroy(gameObject);
        }
        if(collision.tag == "Enemy")
        {
            Destroy(gameObject);
            collision.GetComponent<AngryPig>().TakeDamage(damage);
        }
    }
}
