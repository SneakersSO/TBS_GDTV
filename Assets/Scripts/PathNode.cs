using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode
{
    private GridPosition gridPosition;
    private int gCost;
    private int hCost;
    private int fCost;

    //Stores the reference from the PathNode the unit came from in order to reach this PathNode that its currently on.
    private PathNode cameFromPathNode;

    public PathNode(GridPosition gridPosition)
    {
        this.gridPosition = gridPosition;
    }

    public override string ToString() => gridPosition.ToString();
    public int GetGCost() => gCost;
    public int GetFCost() => fCost;
    public int GetHCost() => hCost;
}
