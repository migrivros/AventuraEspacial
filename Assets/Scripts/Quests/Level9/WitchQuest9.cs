using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WitchQuest9 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyBossLife = 4000;

    public static bool complete = false;

    void Start()
    {
        enemyBossLife = 1500;
    }

    private void Update()
    {
        if (complete == true)
        {
            FinishQuest();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyBossLife = enemyBossLife - Bullet.damage;
        if(enemyBossLife <= 0){
            FinishQuest();
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition9.CheckQuests();
    }
}
