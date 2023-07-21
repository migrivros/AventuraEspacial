using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NinjaQuest6 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyBossLife = 1000;

    public static bool complete = false;

    void Start()
    {
        complete = false;
        enemyBossLife = 1000;
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
