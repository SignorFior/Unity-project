using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;
using UnityEngine.WSA;


public class mouseinput : MonoBehaviour
{
        public Grid grid;
        private Vector3 PositionInCell;
        private Vector3 CellInPosition;
        public Transform camTransf;
        public Camera camCam;
        public GameObject cubePrefab;
        private int RayHitPoint;
        private Vector3 ScreenResol;
        private Vector3 MousePos;

        
        // Start is called before the first frame update
        void Start()
        {
        

            Debug.Log(grid); 
            Debug.Log(camTransf);
            Debug.Log(camCam);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
            
                MousePos = Input.mousePosition;
                //Debug.Log(MousePos + "MOUSE POS");

                CellInPosition = camCam.ScreenToWorldPoint(MousePos);
                //Debug.Log(CellInPosition + "CEll");

                PositionInCell = grid.WorldToCell(CellInPosition);
                //Debug.Log(PositionInCell + "Positoon");

                Instantiate(cubePrefab, PositionInCell * 5, Quaternion.identity);

            }
    } 
        
}
