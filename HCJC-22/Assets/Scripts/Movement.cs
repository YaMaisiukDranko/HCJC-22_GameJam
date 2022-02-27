using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private AnimationManager AnimMngr;
    
    public Camera mainCam;
    public float SwipeSpeed = 5f;
    public float Speed = 2f;
    private Transform localTransform;
    private Vector3 lastMousePos;
    private Vector3 mousePos;
    private Vector3 newPosForTrans;

    private void Start()
    {
        localTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        AnimMngr.animator.SetBool("IsMoving" , true);
        mousePos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
            float xDiff = mousePos.x - lastMousePos.x;

            newPosForTrans.x = localTransform.position.x + xDiff * Time.deltaTime * SwipeSpeed;
            newPosForTrans.y = localTransform.position.y;
            newPosForTrans.z = localTransform.position.z;

            localTransform.position = newPosForTrans + localTransform.forward * Speed * Time.deltaTime;

            lastMousePos = mousePos;
            
        
    }
}