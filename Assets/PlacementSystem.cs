using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] 
    private GameObject mouseIndicator;
    [SerializeField] 
    private mousePointRay mousePointRay;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            //PositionInCell = grid.WorldToCell(lastPosition);
            Instantiate(mousePointRay.cubePrefab, mousePointRay.lastPosition, Quaternion.identity);

        }
       // Vector3 mousePosition = mousePointRay.GetSelectedMapPosition();
        //mouseIndicator.transform.position = mousePosition;
    }
}
