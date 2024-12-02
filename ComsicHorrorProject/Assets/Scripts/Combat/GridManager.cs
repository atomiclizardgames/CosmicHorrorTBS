using System;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width, height;
    public GameObject tilePrefab;
    
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Instantiate(tilePrefab, new Vector3(x,y, 1), Quaternion.identity);
            }
        }
    }
}
