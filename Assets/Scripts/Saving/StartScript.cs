using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public CurrentProgressSerialized SerializedData = null;
    public static CurrentProgress CurrentProgressData;

    void Start(){
        SavingSys.Save(new CurrentProgress());
        SerializedData = SavingSys.Load();
        if(SerializedData!=null){
            CurrentProgressData = new CurrentProgress(SerializedData);
        }else{
            CurrentProgressData = new CurrentProgress();
        }
    }

    private float nextActionTime = 0f;
    private float period = 1f;//300f;

    void Update(){
        if (Time.time > nextActionTime){
            nextActionTime += period;
            SavingSys.Save(CurrentProgressData);
            CurrentProgressData.DaysPassed++;
        }
    }
}
