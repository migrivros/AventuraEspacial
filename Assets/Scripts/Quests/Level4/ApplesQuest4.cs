using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ApplesQuest4 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    [SerializeField] private Text applesText;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        applesText.text = "Obtener manzanas: " + ItemCollector.apples + "/3";

        if (ItemCollector.apples == 3)
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
