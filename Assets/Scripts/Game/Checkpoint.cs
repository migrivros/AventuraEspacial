using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Animator animator;

    private AudioSource checkpointSound;

    public static int savedCherries = 0;
    public static int savedOranges = 0;
    public static int savedApples = 0;
    public static int savedMelons = 0;
    public static int savedCoins = 0;
    public static int savedgGasolines = 0;
    public static int savedMaps = 0;
    public static int savedKeys = 0;

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
            
            savedCherries = ItemCollector.cherries;
            savedOranges = ItemCollector.oranges;
            savedApples = ItemCollector.apples;
            savedMelons = ItemCollector.melons;
            savedCoins = ItemCollector.coins;
            savedgGasolines = ItemCollector.gasolines;
            savedMaps = ItemCollector.maps;
            savedKeys = ItemCollector.keys;
        }
    }
}
