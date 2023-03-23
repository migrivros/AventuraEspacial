using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject levelFinishMenu;

    private AudioSource finishSound;

    private bool levelComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelComplete)
        {
            finishSound.Play();
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            levelFinishMenu.SetActive(true);
            levelComplete = true;
            
        }
    } 
}
