using UnityEngine;
using System.Collections;

public class MapData
{
    public Vector2Int Size { get; set; }
    public int Seed { get; set; }
    public bool[,] Grid { get; set; }
    
    public MapData()
    {
        Size = new Vector2Int(10, 10);
        Seed = 0;
        Grid = new bool[Size.x, Size.y];
    }

    public MapData(Vector2Int size, int seed)
    {
        Size = size;
        Seed = seed;
        Grid = new bool[size.x, size.y];
    }
}
