using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public static int cherries = 0;
    public static int oranges = 0;
    public static int apples = 0;
    public static int melons = 0;
    public static int coins = 0;
    public static int gasolines = 0;
    public static int maps = 0;
    public static int keys = 0;

    [SerializeField] private Text cherryText;
    [SerializeField] private Text orangeText;
    [SerializeField] private Text appleText;
    [SerializeField] private Text melonText;
    [SerializeField] private Text coinText;
    [SerializeField] private Text gasolineText;
    [SerializeField] private Text mapText;
    [SerializeField] private Text keyText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;

            cherryText.text = "Obtener cerezas: " + cherries + "/3";
        }
        if(collision.gameObject.CompareTag("Orange"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            oranges++;

            orangeText.text = "Obtener naranjas: " + oranges + "/3";
        }
        if(collision.gameObject.CompareTag("Melon"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;

            //melonText.text = "Melones: " + melons;
        }
        if(collision.gameObject.CompareTag("Apple"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            apples++;

            appleText.text = "Obtener manzanas: " + apples + "/3";
        }
        if(collision.gameObject.CompareTag("Coin"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            
            coinText.text = "Obtener monedas: " + coins + "/3";
        }
        if(collision.gameObject.CompareTag("Gasoline"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            gasolines++;
            
            gasolineText.text = "Obtener combustible: " + gasolines + "/3";
        }
        if(collision.gameObject.CompareTag("Map"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            maps++;
            
            mapText.text = "Encontrar mapas: " + maps + "/3";
        }
        if(collision.gameObject.CompareTag("Key"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            keys++;
            
            keyText.text = "Conseguir llaves: " + keys + "/3";
        }
    }
}
