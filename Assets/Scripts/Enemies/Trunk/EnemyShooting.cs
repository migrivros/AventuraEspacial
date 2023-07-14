using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPosition;

    private float timer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < 10 && MediumEnemy.enemyLife > 0 && HealthManager.playerHealth > 0)
        {
            timer += Time.deltaTime;

            if(timer > 3.25f)
            {
                timer = 0;
                shoot();
            }
        } 
    }

    void shoot()
    {
        Instantiate(bullet, bulletPosition.position, Quaternion.identity);
    }
}
