using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(CherryQuest.complete == true && CheckPointQuest.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
