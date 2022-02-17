using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{
    public Slider slider;

    void Update(){
        slider.value = StartScript.CurrentProgressData.XP;
    }
}
