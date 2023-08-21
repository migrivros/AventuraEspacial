using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeysQuest9 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public GameObject capabilityUpgradeAdvise;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        if(ItemCollector.keys == 3)
        {
            if(complete == false)
            {
                Bullet.damage = 100;
                capabilityUpgradeAdvise.SetActive(true);
            }
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
        FinishCondition9.CheckQuests();
    }
}
