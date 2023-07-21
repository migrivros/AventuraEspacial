using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pauseMenu;
    public GameObject finishLevelMenu;
    public GameObject notCompleteQuestScreen;


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

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
        PlayerManager.lastCheckPoint = new Vector2(-239, 1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerManager.lastCheckPoint = new Vector2(-239, 1);
    }

    public void AcceptMenu()
    {
        Time.timeScale = 1;
        notCompleteQuestScreen.SetActive(false);
    }

}
