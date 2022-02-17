using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
    public AddCrops crops;
    public int index;
    private MinionStats stats;

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.gameObject.name);
        
        if(other.gameObject.name == "Minion"){
            stats = other.gameObject.GetComponent<MinionStats>();
            index = crops.Index;
            if(StartScript.CurrentProgressData.Soils[index,4]==4){
                Take();
            }else if(StartScript.CurrentProgressData.Soils[index,2] == 11){
                Plant();
            }else if(StartScript.CurrentProgressData.Soils[index,4]<4 && StartScript.CurrentProgressData.Soils[index,4]>0 && StartScript.CurrentProgressData.Soils[index,7]==0){
                Water();
            }
        }
    }

    void Water(){
        Debug.Log("Water");
        StartScript.CurrentProgressData.Soils[index,7]=1;
    }

    void Take(){
        crops.rend.sprite= null;
        stats.isCarrying = true;
        StartScript.CurrentProgressData.Soils[index,2] = 11;
        StartScript.CurrentProgressData.Soils[index,3] = 0;
        StartScript.CurrentProgressData.Soils[index,4] = 0; 
        StartScript.CurrentProgressData.Soils[index,5] = 0;
        StartScript.CurrentProgressData.Soils[index,6] = 0;
        StartScript.CurrentProgressData.Soils[index,7] = 0;
    }

    void Plant(){
        crops.rend.sprite= Defaults.Crops[stats.Plant,0];
        StartScript.CurrentProgressData.Soils[index,2] = stats.Plant;
        StartScript.CurrentProgressData.Soils[index,3] = stats.Plant;
        StartScript.CurrentProgressData.Soils[index,4] = 0; 
        StartScript.CurrentProgressData.Soils[index,5] = StartScript.CurrentProgressData.DaysPassed;
        StartScript.CurrentProgressData.Soils[index,6] = Defaults.CropsTime[stats.Plant];
        StartScript.CurrentProgressData.Soils[index,7] = 0;
    }
}
