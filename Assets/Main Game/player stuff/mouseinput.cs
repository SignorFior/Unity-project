using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class mouseinput : MonoBehaviour
{
    public GridLayout grid;
    private Vector3 PositionInCell;
    private Vector3 CellInPosition = new Vector3( 605.00f, 374.00f, 0.00f);
    private Vector3Int CellInPositionINT = new Vector3Int( 605, 374, 0);


    //  GridLayout gridLayout = transform.parent.GetComponent<GridLayout>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("s");
        GridLayout gird = this.gameObject.GetComponent<GridLayout>();
        Debug.Log(gird);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            Camera camera = Camera.main;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            float angle = Vector3.Angle(camera.transform.forward, ray.direction);
           // CellInPosition = Input.mousePosition;
            Debug.Log("CellInPosition" + CellInPosition);
            Debug.Log("PositionInCell" + ray);
            PositionInCell = grid.LocalToCell(CellInPosition);
            Debug.Log("PositionInCell" + PositionInCell);
            
            
        }

    }
}
