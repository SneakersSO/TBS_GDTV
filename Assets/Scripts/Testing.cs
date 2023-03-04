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
            MyClass myClass = new MyClass(6);
            myClass.Testing<string>("test");

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
