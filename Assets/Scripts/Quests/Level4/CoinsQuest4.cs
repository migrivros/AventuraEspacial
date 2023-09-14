using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsQuest4 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public static bool complete = false;

    [SerializeField] private Text coinsText;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        coinsText.text = "Obtener monedas: " + ItemCollector.coins + "/3";
        
        if (ItemCollector.coins == 3)
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
        FinishCondition4.CheckQuests();
    }
}
