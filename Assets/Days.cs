using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Days : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = "Days: "+  StartScript.CurrentProgressData.DaysPassed.ToString();
    }
}
