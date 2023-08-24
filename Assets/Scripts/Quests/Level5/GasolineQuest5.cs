using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GasolineQuest5 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public static bool complete = false;

    [SerializeField] private Text gasolineText;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        gasolineText.text = "Obtener combustible: " + ItemCollector.gasolines + "/3";

        if (ItemCollector.gasolines == 3)
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
        FinishCondition5.CheckQuests();
    }
}
