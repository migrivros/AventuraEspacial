using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition3 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(CoinsQuest3.complete == true && BatQuest3.complete == true && KnightQuest3.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
