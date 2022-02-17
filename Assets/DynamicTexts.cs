using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicTexts : MonoBehaviour
{
    public GameObject Minion;

    void Update(){
        gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = Minion.GetComponent<MinionStats>().level.ToString(); 
        gameObject.transform.GetChild(1).GetComponent<UnityEngine.UI.Text>().text = Minion.GetComponent<MinionStats>().currentXP.ToString() + "/" + Minion.GetComponent<MinionStats>().XPtoNextLvl.ToString(); 
        gameObject.transform.GetChild(2).GetComponent<UnityEngine.UI.Text>().text = Minion.GetComponent<MinionStats>().happiness.ToString(); 
        gameObject.transform.GetChild(3).GetComponent<UnityEngine.UI.Text>().text = Minion.GetComponent<MinionStats>().FavouriteFood.ToString(); 
        gameObject.transform.GetChild(4).GetComponent<UnityEngine.UI.Text>().text = Minion.GetComponent<MinionStats>().health.ToString(); 
    }
}
