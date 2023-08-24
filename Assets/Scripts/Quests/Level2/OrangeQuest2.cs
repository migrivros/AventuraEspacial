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

    [SerializeField] private Text orangeText;

    void Start()
    {
        complete = false;
    }

    private void Update()
    {
        orangeText.text = "Obtener naranjas: " + ItemCollector.oranges + "/3";

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
