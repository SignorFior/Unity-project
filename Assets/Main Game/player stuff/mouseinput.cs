using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class mouseinput : MonoBehaviour
{
        public Grid grid;
        private Vector3 PositionInCell;
        private RaycastHit2D CellInPosition;
        public GameObject cubePrefab;
        private int RayHitPoint;

        //  GridLayout gridLayout = transform.parent.GetComponent<GridLayout>();
        // Start is called before the first frame update
        void Start()
        {
            
            Debug.Log("s");
            Grid gird = this.gameObject.GetComponent<Grid>();
            Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white, 2.5f);
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
                CellInPosition = Physics2D.Raycast(ray.origin, ray.direction);
                Debug.DrawRay(camera.transform.forward, ray.origin, Color.white, 1f);
                
                //PositionInCell = grid.WorldToCell(CellInPosition);
                //Instantiate(cubePrefab, PositionInCell, Quaternion.identity);


               // Debug.Log("CellInPosition" + ray);
                Debug.Log("CellInPosition" + CellInPosition);

                Debug.Log("PositionInCell" + PositionInCell);


            }

      } 
}
