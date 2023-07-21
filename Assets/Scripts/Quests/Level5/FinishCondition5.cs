using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition5 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(CoinsQuest5.complete == true && RhinoQuest5.complete == true && GasolineQuest5.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
