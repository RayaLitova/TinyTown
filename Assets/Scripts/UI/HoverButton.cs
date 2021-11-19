using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverButton : MonoBehaviour
{

    public Sprite Hover;
    public Sprite Default;
    public Image rend;

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
}
