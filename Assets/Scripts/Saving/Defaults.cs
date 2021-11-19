using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defaults : MonoBehaviour
{
    public static Sprite[,] Crops;
    public static string[] CropsNames;
    public static int[] CropsTime;
    private string Cname;

    void Start(){
        Crops = new Sprite[11,6];
        CropsNames = new string[12]{"beetroot", "cabbage", "carrot", "cauliflower", "kale", "parsnip", "potato", "pumpkin", "radish", "sunflower", "wheat", "empty"};
        CropsTime = new int[11]{8, 10, 11, 12, 6, 16, 13, 17, 3, 10, 1};

        for(int i=0; i<11; i++){
            for(int j=0;j<6;j++){
                Cname = CropsNames[i] + "_0" + j;
                Crops[i,j] = Resources.Load<Sprite>(Cname);                
            }
        }
        
    }

}
