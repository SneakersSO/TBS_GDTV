using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Unit unit;
    
    private void Start()
    {
        
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            GridPosition mouseGridPosition = LevelGrid.Instance.GetGridPosition(MouseWorld.GetPosition());
            GridPosition startGridPosition = new GridPosition(0, 0);

            List<GridPosition> gridPositionList = Pathfinding.Instance.FindPath(startGridPosition, mouseGridPosition);

            for (int i = 0; i < gridPositionList.Count - 1; i++)
            {
                Debug.DrawLine(
                    LevelGrid.Instance.GetWorldPosition(gridPositionList[i]),
                    LevelGrid.Instance.GetWorldPosition(gridPositionList[i + 1]),
                    Color.white,
                    10f
                );
            } 
        }
    }

    //public Action<int>();
    //public Func<int>();
}

/*GENERICS*/
//With the 'where' keyword, you can make it so the variable type T has to specifically extend from a class
//Or else the compiler will reject it. In the below example, T must be extended from BaseAction
public class MyClass
{
    private int i;

    public MyClass(int i) 
    {
        this.i = i;
        Debug.Log(i);
    }

    public void Testing<T>(T t) 
    {
        Debug.Log(t);
    }
}
