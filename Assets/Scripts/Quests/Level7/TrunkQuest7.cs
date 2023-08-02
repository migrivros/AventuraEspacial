using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrunkQuest7 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    public static int trunkLife = 300;

    public static bool complete = false;

    void Start()
    {
        trunkLife = 300;
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
        if(collision.tag == "Bullet")
        {
            trunkLife = trunkLife - 50;
            if(trunkLife == 0){
                FinishQuest();
            }
        } 
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition7.CheckQuests();
    }
}
