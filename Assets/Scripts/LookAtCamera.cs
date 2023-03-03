using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] private bool invert;
    private Transform cameraTransform;

    private void Awake() 
    {
        cameraTransform = Camera.main.transform;
    }

    //LateUpdate() - similar to Update, only it will run after every other Update call does.
    private void LateUpdate()
    {
        if (invert)
        {
            Vector3 dirToCamera = (cameraTransform.position - transform.position).normalized;
            transform.LookAt(transform.position + dirToCamera  * -1);

        } else 
        {
            transform.LookAt(cameraTransform);
        }
        
    }
}
