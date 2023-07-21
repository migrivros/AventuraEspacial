using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RhinoQuest5 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int enemyLife = 500;

    public static bool complete = false;

    void Start()
    {
        enemyLife = 500;
        complete = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyLife = enemyLife - 50;
        if(enemyLife == 0){
            FinishQuest();
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition5.CheckQuests();
    }
}
