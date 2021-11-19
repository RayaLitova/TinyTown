using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraZoom : MonoBehaviour
{
    private float targetZoom;
    private float zoomFactor = 3f;
    private float zoomSpeed = 10f;

    void OnGUI(){
        Event e = Event.current;
        if (e.isMouse)
        {
            if(e.clickCount == 2 && !StartScript.CurrentProgressData.StopScreenMoving){
                targetZoom = 4.5f;
                Camera.main.orthographicSize = targetZoom;
                Camera.main.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                MoveCamera.drag = false;
            }
        }
    }

    void Start(){
        targetZoom = Camera.main.orthographicSize;
    }

    void Update(){
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");

        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 10f);
        Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, targetZoom, Time.deltaTime * zoomSpeed);

    }
}
