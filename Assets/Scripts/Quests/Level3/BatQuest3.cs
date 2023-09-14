using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BatQuest3 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyLife = 100;

    public static bool complete = false;

    void Start()
    {
        enemyLife = 100;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyLife = enemyLife - Bullet.damage;
        if(enemyLife <= 0){
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
