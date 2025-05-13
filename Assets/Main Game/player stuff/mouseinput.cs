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
        //private float screenH;
        //private float screenW;
        


        //  GridLayout gridLayout = transform.parent.GetComponent<GridLayout>();
        // Start is called before the first frame update
        void Start()
        {
        //screenH = (Screen.height / 2);
        //screenW = (Screen.width / 2);
        //ScreenResol = new Vector3(screenW, screenH, 0f);
            //Debug.Log("s");

            //Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white, 2.5f);
            Debug.Log(grid); 
            Debug.Log(camTransf);
            Debug.Log(camCam);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
            
            //camCam = Camera.main;
                MousePos = Input.mousePosition;
                Debug.Log(MousePos + "MOUSE POS");
                //Debug.Log("CellInPosition" + cam.transform.position);
                //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                //float angle = Vector3.Angle(camera.transform.forward, ray.direction);
                CellInPosition = camCam.ScreenToWorldPoint(MousePos) ; //(Input.mousePosition - ScreenResol) + cam.transform.position; //Physics2D.Raycast(ray.origin, ray.direction);
                //Debug.DrawRay(cam.transform.positi;on, ray.origin, Color.white, 1f);
                Debug.Log(CellInPosition + "CEll");
                PositionInCell = grid.WorldToCell(CellInPosition);
                Debug.Log(PositionInCell + "Positoon");
                Instantiate(cubePrefab, PositionInCell, Quaternion.identity);
                

                //Debug.Log("CellInPosition" + ray);
                //Debug.Log("CellInPosition" + CellInPosition);

                //Debug.Log("PositionInCell" + PositionInCell);
                

            }
    } 
        
}
