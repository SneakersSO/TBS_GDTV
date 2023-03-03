using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectedVisual : MonoBehaviour
{
    [SerializeField] private Unit unit;

    private MeshRenderer meshRenderer;

    private void Awake() 
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        //In order to ensure Instance is already set by the time Start() fires off within UnitSelectedVisual
        //We must ensure that we set Instance in UnitActionSystem in Awake() instead of Start(), since it Awake() fires first
        UnitActionSystem.Instance.OnSelectedUnitChanged += UnitActionSystem_OnSelectedUnitChanged;
        UpdateVisual();
    }

    private void UnitActionSystem_OnSelectedUnitChanged(object sender, EventArgs empty)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (UnitActionSystem.Instance.GetSelectedUnit() == unit)
        {
            meshRenderer.enabled = true;
        } else 
        {
            meshRenderer.enabled = false;
        }
    }

    //OnDestroy() is a built in function extending from MonoBehavior, gets run on the object whenever its destroyed in game/scene
    private void OnDestroy() 
    {
        //Objects that are destroyed must unsub to any events they are listening to when they are destroyed.
        UnitActionSystem.Instance.OnSelectedUnitChanged -= UnitActionSystem_OnSelectedUnitChanged;
    }
}
