using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrangeQuest2 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public static bool complete = false;

    void Start()
    {
        complete = false;
        ItemCollector.oranges = 0;
    }

    private void Update()
    {
        if (ItemCollector.oranges == 3)
        {
            FinishQuest();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
            Destroy(gameObject);
        }
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
        complete = true;
        FinishCondition2.CheckQuests();
    }
}