using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public GameObject TilePrefab;
    public int mapSizeX = 10;
    public int mapSizeY = 10;

    void Start()
    {
        for (int i = 0; i < mapSizeX; i++)
        {
            for (int j = 0; j < mapSizeY; j++)
            {
                transform.position = new Vector3(j, 0, i);
                Instantiate(TilePrefab,transform.position,transform.rotation);
            }
        }
    }
}
