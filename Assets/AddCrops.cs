using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCrops : MonoBehaviour
{
    private int Index;
    public SpriteRenderer rend;

    void Start()
    {
        for(Index=0; StartScript.CurrentProgressData.Soils[Index,0].HasValue; Index++);
        StartScript.CurrentProgressData.Soils[Index,0] = (int)Mathf.Round(gameObject.transform.position.x); //x position of soil
        StartScript.CurrentProgressData.Soils[Index,1] = (int)Mathf.Round(gameObject.transform.position.y); //y position of soil
        StartScript.CurrentProgressData.Soils[Index,2] = 9; //index of cropsname
        StartScript.CurrentProgressData.Soils[Index,3] = 9; //index of crops[x]
        StartScript.CurrentProgressData.Soils[Index,4] = 0; //index of crops[][x]
        StartScript.CurrentProgressData.Soils[Index,5] = StartScript.CurrentProgressData.DaysPassed; //day of planting
        StartScript.CurrentProgressData.Soils[Index,6] = Defaults.CropsTime[9]; //days to harvest

    }

    void Update(){
        if(StartScript.CurrentProgressData.Soils[Index,2]!=11 && StartScript.CurrentProgressData.Soils[Index,6]>(StartScript.CurrentProgressData.DaysPassed-StartScript.CurrentProgressData.Soils[Index,5])){
            float a = ((StartScript.CurrentProgressData.Soils[Index,6]?? default(int))-(StartScript.CurrentProgressData.DaysPassed - (StartScript.CurrentProgressData.Soils[Index,5]?? default(int))));
            a = Mathf.CeilToInt(a/((StartScript.CurrentProgressData.Soils[Index,6]?? default(int))/5));
            a = (a - 5) * (-1);
            
            rend.sprite = Defaults.Crops[(StartScript.CurrentProgressData.Soils[Index,3]?? default(int)),(int)a];
            
        }   
    }

}
