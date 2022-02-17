using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionStats : MonoBehaviour
{
    public string MinionName = "Minion";
    public int level = 0;
    public int currentXP = 0;
    public int XPtoNextLvl = 100;
    public int happiness = 100;
    public string FavouriteFood = "Bread";
    public int health = 100;
    public bool isPrioDefault = true;
    public int[,] Priorities;
    public CloseQuestMenu MinionStatsCloseButton;
    public int Plant;
    public bool isCarrying = false;
    public GameObject CarriedItem;

    void OnMouseOver(){
        if(Input.GetMouseButtonDown(1)){
            MinionStatsCloseButton.Show();
        }
    }
}
