using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSortingLayer : MonoBehaviour
{
    public Canvas cnv;
    void Start()
    {
        cnv.sortingLayerName = "UI";

    }
}


