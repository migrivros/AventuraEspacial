using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int cherries = 0;
    private int oranges = 0;
    private int apples = 0;
    private int melons = 0;
    private int coins = 0;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;

            cherriesText.text = "Cerezas: " + cherries;
        }
        if(collision.gameObject.CompareTag("Orange"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            oranges++;

            //cherriesText.text = "Naranjas: " + oranges;
        }
        if(collision.gameObject.CompareTag("Melon"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;

            //cherriesText.text = "Melones: " + melons;
        }
        if(collision.gameObject.CompareTag("Apple"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            apples++;

            //cherriesText.text = "Manzanas: " + apples;
        }
        if(collision.gameObject.CompareTag("Coin"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;

            //cherriesText.text = "Monedas: " + coins;
        }

    }
}
