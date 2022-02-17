using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;
using System.Threading;

public class GetTiles : MonoBehaviour
{
    public static Tilemap tileMap;
    public static List<Vector3> availablePlaces;
    //public static GameObject minion;

    public static Tuple<int,int> Direction(GameObject minion){
        tileMap = GameObject.Find("Path").GetComponent<Tilemap>();
        availablePlaces = new List<Vector3>();
        Vector2Int minionPos = new Vector2Int((int)minion.transform.position.x, (int)minion.transform.position.y);
        int X = 0, Y=0;
        for (int n = tileMap.cellBounds.xMin; n < tileMap.cellBounds.xMax; n++)
        {
            for (int p = tileMap.cellBounds.yMin; p < tileMap.cellBounds.yMax; p++)
            {
                Vector3Int localPlace = (new Vector3Int(n, p, (int)tileMap.transform.position.y));
                Vector3 place = tileMap.CellToWorld(localPlace);
                if (tileMap.HasTile(localPlace))
                {
                    availablePlaces.Add(place);
                    if((minionPos.x == localPlace.x - 1 || minionPos.x == localPlace.x + 1) && minionPos.y == localPlace.y) X=1;
                    else if((minionPos.y == localPlace.y - 1 || minionPos.y == localPlace.y + 1) && minionPos.x == localPlace.x) Y=1;
                }
            }
        }
        var result = new Tuple<int,int>(X,Y);
        return result; 
    }

}
