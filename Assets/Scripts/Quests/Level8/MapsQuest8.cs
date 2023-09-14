using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapsQuest8 : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    [SerializeField] private Text mapsText;

    public static bool complete = false;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        mapsText.text = "Encontrar mapas: " + ItemCollector.maps + "/3";

        if(ItemCollector.maps == 3)
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
        FinishCondition8.CheckQuests();
    }
}
