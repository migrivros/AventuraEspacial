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
        if(collision.tag == "WeakEnemy")
        {
            Destroy(gameObject);
            collision.GetComponent<WeakEnemy>().TakeDamage(damage);
        }
        if(collision.tag == "MediumEnemy")
        {
            Destroy(gameObject);
            collision.GetComponent<MediumEnemy>().TakeDamage(damage);
        }
        if(collision.tag == "Trunk")
        {
            Destroy(gameObject);
            collision.GetComponent<TrunkMediumEnemy>().TakeDamage(damage);
        }
        if(collision.tag == "StrongEnemy")
        {
            Destroy(gameObject);
            collision.GetComponent<StrongEnemy>().TakeDamage(damage);
        }
        if(collision.tag == "KnightBoss")
        {
            Destroy(gameObject);
            collision.GetComponent<KnightBoss>().TakeDamage(damage);
        }
        if(collision.tag == "NinjaBoss")
        {
            Destroy(gameObject);
            collision.GetComponent<NinjaBoss>().TakeDamage(damage);
        }
        if(collision.tag == "WitchBoss")
        {
            Destroy(gameObject);
            collision.GetComponent<WitchBoss>().TakeDamage(damage);
        }
    }
}
