using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mousePointRay : MonoBehaviour
{
    [SerializeField]
    private Camera sceneCamera;

    [SerializeField]
    public Grid grid;

    [SerializeField]
    public Vector3 lastPosition;

    [SerializeField]
    private LayerMask placementLayermask;
    
    [SerializeField]
    public GameObject cubePrefab;

    private Vector3 PositionInCell;
    public event Action OnClicked, OnExit;

    public float sensorLength = 10f;

    void Update()
    {
        
         if (Input.GetKeyDown(KeyCode.Escape))
             OnExit?.Invoke();
    }

    public bool IsPointerOverUI()
        => EventSystem.current.IsPointerOverGameObject();

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        //mousePos.z = sceneCamera.nearClipPlane;
        Ray ray = sceneCamera.ScreenPointToRay(mousePos);
        
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, placementLayermask))
        {
            lastPosition = hit.point;
            Debug.Log(hit.point);
            Debug.DrawRay(sceneCamera.transform.forward, ray.origin, Color.white, 1f);
        }
        return lastPosition;
    }
    public void Sensors()
    {
        RaycastHit hit;
        Vector3 sensorStartPos = transform.position;
       // sensorStartPos.z += frontSensorPosition;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(sensorStartPos, fwd, out hit, sensorLength))
        {
            //if it a surface, then Draw Red line to the hit point
            Debug.DrawLine(sensorStartPos, hit.point, Color.red, 1f);
        }
        else
        {
            //If don't hit, then draw Green line to the direction we are sensing,
            //Note hit.point will remain 0,0,0 at this point, because we don't hit anything
            //So you cannot use hit.point
            Debug.DrawLine(sensorStartPos, sensorStartPos + (fwd * sensorLength), Color.green, 1f);
        }
    }
}