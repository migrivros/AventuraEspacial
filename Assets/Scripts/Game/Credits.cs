using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CreditsGoToMenu()
    {
        PlayerManager.cleanData();
        SceneManager.LoadScene("Menu");
        PlayerManager.lastCheckPoint = new Vector2(-239, 1);
    }
}
