using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static int playerHealth = 3;

    public Image[] heartsImages;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Awake()
    {
        playerHealth = 3;
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (Image heart in heartsImages)
        {
            heart.sprite = emptyHeart;
        }
        for (int e = 0; e < playerHealth; e++)
        {
            heartsImages[e].sprite = fullHeart;
        }
    }
}
