using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition7 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(MapsQuest7.complete == true && TrunkQuest7.complete == true && CoinsQuest7.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
