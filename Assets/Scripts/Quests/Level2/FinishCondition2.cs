using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition2 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(OrangeQuest2.complete == true && CoinQuest2.complete == true && GreenPigQuest2.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
