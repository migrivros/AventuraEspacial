using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GasolineQuest9 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;
    
    [SerializeField] private Text gasolineText;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        gasolineText.text = "Obtener combustible: " + ItemCollector.gasolines + "/3";

        if(ItemCollector.gasolines == 3)
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
        FinishCondition9.CheckQuests();
    }
}
