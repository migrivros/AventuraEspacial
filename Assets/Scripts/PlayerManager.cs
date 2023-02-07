using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static Vector2 lastCheckPoint = new Vector2(-239, 1);

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Awake()
    {
        isGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPoint;
        //animator.SetInteger("state", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
        
    }

}
