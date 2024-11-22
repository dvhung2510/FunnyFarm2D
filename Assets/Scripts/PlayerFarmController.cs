using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerFarmController : MonoBehaviour
{
    public Tilemap tm_Ground;
    public Tilemap tm_Grass;
    public Tilemap tm_Forest;
    // Start is called before the first frame update

    public TileBase tb_Ground;
    public TileBase tb_Grass;
    public TileBase tb_Forest;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleFarmAction();
    }

    public void HandleFarmAction()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Dao!");

            Vector3Int cellPos = tm_Ground.WorldToCell(transform.position); //xác dinh vi tri dung cua player
            Debug.Log("Cell pos: " + cellPos);

            TileBase crrTileBase = tm_Ground.GetTile(cellPos);

            if(crrTileBase == tb_Grass)
            {
                Debug.Log("aa");
            }
            else
            {
                Debug.Log("bb");
            }

        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Trong hoa !");
        }
    }
}
