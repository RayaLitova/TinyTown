using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPriorities : MonoBehaviour
{
    public GameObject Other;
    public GameObject Minion;

    public void ChangePrio(){
        if(gameObject.name == "DefaultPriorityButton"){
            Minion.GetComponent<MinionStats>().isPrioDefault = true;
        }else{
            Minion.GetComponent<MinionStats>().isPrioDefault = false;
        }
        gameObject.GetComponent<HoverButton>().isButtonActive = true;
        Other.GetComponent<HoverButton>().isButtonActive = false;
        Other.GetComponent<HoverButton>().defMENUS();
    }
}
