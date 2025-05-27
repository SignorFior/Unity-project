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
        public GameObject cubePrefab;
        private int RayHitPoint;
        private Vector3 ScreenResol;
        private Vector3 MousePos;
        public Transform PlayerPosition;
        private Vector3 centering = new Vector2(0.5f, 0.5f);

        
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
                RaycastHit2D hit = Physics2D.Raycast(WorldInCell + centering, PlayerPosition.transform.position, 0.9f);
                Debug.DrawRay(WorldInCell, PlayerPosition.transform.position + centering, Color.blue, 1f);
                //Debug.Log(WorldInCell + "World Cell    " );
                Debug.Log(PlayerPosition.transform.position + centering);
                Debug.Log("Player Positioning menus centring    " + PlayerPosition.transform.position);
                if (hit)
                {
                    Debug.Log(hit.collider);
                }
                else
                {
                    Instantiate(cubePrefab, WorldInCell, Quaternion.identity);
                }
                

                }
        }
        void FixedUpdate()
        {
            
        }

}
