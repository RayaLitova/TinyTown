using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class CurrentProgress
{
    //public Minion[] Minions;
    public Vector2[] Path;
    public int level;
    public Vector2 position;
    public float XP;
    public float XP_ToNext;
    public bool StopScreenMoving;
    public uint Currency;
    public int?[,] Soils;
    public int?[] CropsAvailable;
    public int DaysPassed;

    public CurrentProgress(CurrentProgressSerialized c){
        DaysPassed = c.DaysPassed;
        XP_ToNext = c.XP_ToNext;
        XP = c.XP;
        level = c.level;
        position = new Vector2(c.pos[0], c.pos[1]);
        StopScreenMoving = false;
        Currency = c.Currency;
        Soils = new int?[100, 8];
        for(int i=0;c.Soils[i,0].HasValue;i++){
            for(int j=0;j<7;j++){
                Soils[i,j] = c.Soils[i,j];
            }
        }
        CropsAvailable = new int?[11];
        for(int i=0; c.CropsAvailable[i].HasValue;i++){
            CropsAvailable[i] = c.CropsAvailable[i];
        }
    }

    public CurrentProgress(){
        DaysPassed = 0;
        XP_ToNext = 100;
        XP = 0;
        level=0;
        position = new Vector2(0,0);
        StopScreenMoving = false;
        Currency = 100;
        Soils = new int?[100, 8];
        CropsAvailable = new int?[11];
        CropsAvailable[0] = 11;

    }

    public void ApplyProgress(){
        Debug.Log("Applied progress!");
    }
}

[System.Serializable]
public class CurrentProgressSerialized
{
    public int DaysPassed;
    public int level;
    public float[] pos;
    public float XP;
    public float XP_ToNext;
    public uint Currency;
    public int?[,] Soils;
    public int?[] CropsAvailable;

    public CurrentProgressSerialized(CurrentProgress c){
        DaysPassed = c.DaysPassed;
        XP_ToNext = c.XP_ToNext;
        XP = c.XP;
        level = c.level;
        pos = new float[2];
        pos[0] = c.position.x;
        pos[1] = c.position.y;
        Currency = c.Currency;
        Soils = new int?[100, 8];
        for(int i=0;c.Soils[i,0].HasValue;i++){
            for(int j=0;j<8;j++){
                Soils[i,j] = c.Soils[i,j];
            }
        }

        CropsAvailable = new int?[11];
        for(int i=0; c.CropsAvailable[i].HasValue;i++){
            CropsAvailable[i] = c.CropsAvailable[i];
        }
    }
}