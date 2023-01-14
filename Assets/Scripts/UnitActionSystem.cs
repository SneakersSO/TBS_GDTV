using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionSystem : MonoBehaviour
{
    [SerializeField] Unit selectedUnit;

    private void Update() 
    {
        HandleUnitSelection();
        
        if (Input.GetMouseButtonDown(0))
        {
            selectedUnit.Move(MouseWorld.GetPosition());
        }
    }

    private void HandleUnitSelection()
    {

    }
}
