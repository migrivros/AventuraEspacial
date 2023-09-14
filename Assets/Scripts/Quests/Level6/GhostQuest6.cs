using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GhostQuest6 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyLife = 500;

    public static bool complete = false;

    public GameObject capabilityUpgradeAdvise;

    void Start()
    {
        enemyLife = 500;
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
        enemyLife = enemyLife - Bullet.damage;
        if(enemyLife <= 0){
            if(complete == false)
            {
                Bullet.damage = 100;
                capabilityUpgradeAdvise.SetActive(true);
            }
            FinishQuest();
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition6.CheckQuests();
    }
}
