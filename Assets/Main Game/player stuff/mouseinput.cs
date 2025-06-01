using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;
using UnityEngine.WSA;


public class mouseinput : MonoBehaviour
{
        public Grid grid;
        private Vector3 WorldInCell;
        private Vector3 MouseInWorld;
        public Camera camCam;
        public TileBase SquarePrefab;
        private Vector3 MousePos;
        public Transform PlayerPosition;
        private Vector3 centering = new Vector3(0.5f, 0.5f);
        public Tilemap tilemap;
        public ExampleClass scriptIONC;
        public GameObject IONC;

        
        // Start is called before the first frame update
        void Start()
        {
        
            //Debug.Log(grid); 
            //Debug.Log(camCam);
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
            

                MousePos = Input.mousePosition;
                //Debug.Log(MousePos + "MOUSE POS");
                MouseInWorld = camCam.ScreenToWorldPoint(MousePos);
                //Debug.Log(MouseInWorld + "CEll");
                WorldInCell = grid.WorldToCell(MouseInWorld);
                //Debug.Log(WorldInCell + "Positoon");



                RaycastHit2D Hit = Physics2D.BoxCast(WorldInCell + centering, new Vector2(0.98f, 0.98f), 0f, new Vector2(0, 0));
                //OnDrawGizmos();


                    if (Hit)
                    {
                        Debug.Log("IT WAS TRUE.              SETTING TO FALSE");
                        
                    }
                    else
                    {
                        Debug.Log("IT WASS FALSE");

                        tilemap.SetTile(Vector3Int.FloorToInt(WorldInCell), SquarePrefab);
                    }



                //RaycastHit2D hit = Physics2D.Raycast(WorldInCell + centering, PlayerPosition.transform.position, 0.5f);

                //Debug.DrawLine(WorldInCell + centering, PlayerPosition.transform.position, Color.blue, 1f

            }
        
        }
        
}   
