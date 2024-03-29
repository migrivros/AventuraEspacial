using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCollect : MonoBehaviour
{

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry") || collision.gameObject.CompareTag("Orange")
        || collision.gameObject.CompareTag("Apple") || collision.gameObject.CompareTag("Melon"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            if(HealthManager.playerHealth < 3)
            {
                HealthManager.playerHealth++;
            }
        }

    }
}
