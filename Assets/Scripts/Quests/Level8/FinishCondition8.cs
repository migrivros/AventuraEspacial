using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition8 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(KeysQuest8.complete == true && CoinsQuest8.complete == true && MapsQuest8.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
