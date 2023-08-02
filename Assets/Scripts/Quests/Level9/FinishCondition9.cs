using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishCondition9 : MonoBehaviour
{

    public static void CheckQuests()
    {
        if(KeysQuest9.complete == true && GasolineQuest9.complete == true && WitchQuest9.complete == true)
        {
            Finish.questsComplete = true;
        }
    } 
}
