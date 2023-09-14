using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckPointQuest4 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            FinishQuest();
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition4.CheckQuests();
    }
}
