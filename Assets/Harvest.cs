using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
    void Update(){
        for(int i=0;StartScript.CurrentProgressData.Soils[i,0].HasValue;i++){
            Debug.Log(i);
            if(new Vector2(StartScript.CurrentProgressData.Soils[i,0]??default(int),StartScript.CurrentProgressData.Soils[i,1]??default(int)) == (Vector2)transform.position){
                if(StartScript.CurrentProgressData.Soils[i,4]==4){
                    StartScript.CurrentProgressData.Soils[i,4]=5;
                    Take();
                }
            }
        }
    }

    void Take(){
        Debug.Log("take");
    }
}
