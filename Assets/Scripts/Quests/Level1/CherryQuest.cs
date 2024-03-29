using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CherryQuest : MonoBehaviour
{
    public Text questItem;
    public Color completedColor;

    public static bool complete = false;

    [SerializeField] private Text cherryText;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        cherryText.text = "Obtener cerezas: " + ItemCollector.cherries + "/3";

        if (ItemCollector.cherries == 3)
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
        FinishCondition.CheckQuests();
    }
}
