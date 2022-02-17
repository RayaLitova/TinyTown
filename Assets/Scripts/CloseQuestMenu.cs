using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseQuestMenu : MonoBehaviour
{
    public GameObject a;
    public bool Enable;

    public void QuestMenu(){
        a.SetActive(Enable);
        if(!Enable){
            StartScript.CurrentProgressData.StopScreenMoving = false;
        }
    }
    public void Show(){
        a.SetActive(true);
    }
}
