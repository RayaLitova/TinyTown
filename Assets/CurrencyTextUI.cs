using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyTextUI : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = StartScript.CurrentProgressData.Currency.ToString("n1");
    }
}
