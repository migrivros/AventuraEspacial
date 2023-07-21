using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KnightQuest3 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyBossLife = 750;

    public static bool complete = false;

    void Start()
    {
        complete = false;
        enemyBossLife = 750;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyBossLife = enemyBossLife - 50;
        if(enemyBossLife == 0){
            FinishQuest();
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition3.CheckQuests();
    }
}
