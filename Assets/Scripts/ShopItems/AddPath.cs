using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AddPath : MonoBehaviour
{
    public static bool EnablePath;
    public GameObject NewTile;
    public Tilemap world;
    public Tilemap path;
    public TileBase pathTile;
    public TileBase worldTile;

    public void Enable_Disable(){
        EnablePath = !EnablePath;
        NewTile.GetComponent<Renderer>().enabled = EnablePath;
    }
    void Update(){
        if(EnablePath){
            Debug.Log(NewTile.transform.position);
            NewTile.transform.position = new Vector2(Mathf.Ceil(Camera.main.ScreenToWorldPoint(Input.mousePosition).x)-0.5f, Mathf.Ceil(Camera.main.ScreenToWorldPoint(Input.mousePosition).y)-0.5f);
        }
        if(EnablePath){
            if(Input.GetMouseButtonDown(0)){
                world.SetTile(new Vector3Int((int)(NewTile.transform.position.x-0.5f),(int)(NewTile.transform.position.y-0.5f),0), null);
                path.SetTile(new Vector3Int((int)(NewTile.transform.position.x-0.5f),(int)(NewTile.transform.position.y-0.5f),0), pathTile);
            }

            if(Input.GetMouseButtonDown(1)){
                path.SetTile(new Vector3Int((int)(NewTile.transform.position.x-0.5f),(int)(NewTile.transform.position.y-0.5f),0), null);
                world.SetTile(new Vector3Int((int)(NewTile.transform.position.x-0.5f),(int)(NewTile.transform.position.y-0.5f),0), worldTile);
            }
        }
    }


}
