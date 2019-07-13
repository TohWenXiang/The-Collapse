using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    MapData theMapData;

    public Map()
    {
        theMapData = new MapData();
    }

    public Map(Vector2Int size, int seed)
    {
        theMapData = new MapData(size, seed);
    }

    public Vector2Int FindNeighbour(Vector2Int currentIndex, int direction)
    {
        if (theMapData.Grid[currentIndex.x, currentIndex.y] == true
    }

    public List<Vector2Int> FindNeighbours(Vector2Int currentIndex)
    {
        List<Vector2Int> neighbours = new List<Vector2Int>();

        for (int i = 0; i < 8; i++)
        {
            neighbours.Add(FindNeighbour(currentIndex, i));
        }

        return neighbours;
    }
}
