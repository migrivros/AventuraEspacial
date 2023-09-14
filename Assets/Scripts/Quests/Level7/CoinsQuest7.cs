using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsQuest7 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    [SerializeField] private Text coinsText;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        coinsText.text = "Obtener monedas: " + ItemCollector.coins + "/3";

        if(ItemCollector.coins == 3)
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
        FinishCondition7.CheckQuests();
    }
}
