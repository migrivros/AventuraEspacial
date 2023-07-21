using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject levelFinishMenu;
    public GameObject notCompleteQuestScreen;

    private AudioSource finishSound;

    private bool levelComplete = false;
    public static bool questsComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
        questsComplete = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelComplete && questsComplete)
        {
            finishSound.Play();
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            levelFinishMenu.SetActive(true);
            levelComplete = true;
        }
        else if(collision.gameObject.name == "Player" && !questsComplete)
        {
            notCompleteQuestScreen.SetActive(true);
        }
    } 
}
