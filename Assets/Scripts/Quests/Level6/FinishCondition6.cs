using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition6 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(CoinsQuest6.complete == true && GhostQuest6.complete == true && NinjaQuest6.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
