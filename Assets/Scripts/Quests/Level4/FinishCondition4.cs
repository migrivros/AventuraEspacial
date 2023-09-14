using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition4 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(CoinsQuest4.complete == true && CheckPointQuest4.complete == true && ApplesQuest4.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
