using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisableCameraMoving : MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler {

    public void OnPointerEnter(PointerEventData data)
    {
        StartScript.CurrentProgressData.StopScreenMoving = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        StartScript.CurrentProgressData.StopScreenMoving = false;
    }

 }

