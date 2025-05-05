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

    void Update()
    {
        
        /* if (Input.GetKeyDown(KeyCode.Escape))
             OnExit?.Invoke();*/
    }

    public bool IsPointerOverUI()
        => EventSystem.current.IsPointerOverGameObject();

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = sceneCamera.nearClipPlane;
        Ray ray = sceneCamera.ScreenPointToRay(mousePos);
        Debug.DrawRay(sceneCamera.transform.forward, ray.origin, Color.white, 1f);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, placementLayermask))
        {
            lastPosition = hit.point;
        }
        return lastPosition;
    }
}