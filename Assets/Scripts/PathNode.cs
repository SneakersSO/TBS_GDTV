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
    private bool isWalkable = true;

    public PathNode(GridPosition gridPosition)
    {
        this.gridPosition = gridPosition;
    } 

    public override string ToString() => gridPosition.ToString();
    public int GetGCost() => gCost;
    public int GetFCost() => fCost;
    public int GetHCost() => hCost;
    public bool GetIsWalkable() => isWalkable;
    public void SetIsWalkable(bool isWalkable) => this.isWalkable = isWalkable;
    public void SetGCost(int gCost) => this.gCost = gCost;
    public void SetHCost(int hCost) => this.hCost = hCost;
    public void CalculateFCost() => fCost = gCost + hCost;
    public void ResetCameFromPathNode() => cameFromPathNode = null;
    public void SetCameFromPathNode(PathNode pathNode) => cameFromPathNode = pathNode;
    public PathNode GetCameFromPathNode() => cameFromPathNode;
    public GridPosition GetGridPosition() => gridPosition;
}
