using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverButton : MonoBehaviour
{

    public Sprite Hover;
    public Sprite Default;
    public Sprite Click;
    public Image rend;
    public bool isButtonActive = false;

    public void hov()
    {
        StartScript.CurrentProgressData.StopScreenMoving = true;
        rend.sprite = Hover;
    }
    public void def()
    {
        StartScript.CurrentProgressData.StopScreenMoving = false;
        rend.sprite = Default;
    }
    public void defMENUS()
    {
        if(!isButtonActive){
            StartScript.CurrentProgressData.StopScreenMoving = true;
            rend.sprite = Default;
        }
    }
    public void hovMENUS()
    {
        if(!isButtonActive){
            StartScript.CurrentProgressData.StopScreenMoving = true;
            rend.sprite = Hover;
        }
    }
    public void ClickFunc(){
        isButtonActive = !isButtonActive;
        rend.sprite = Click;
    }
}
