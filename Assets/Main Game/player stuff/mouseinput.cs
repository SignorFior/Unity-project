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
        
        [SerializeField] private Grid grid;
        private Vector3 WorldInCell;
        private Vector3 MouseInWorld;
        [SerializeField] private Camera camCam;
        [SerializeField] private TileBase SquarePrefab;
        private Vector3 MousePos;
        private Vector3 centering = new Vector3(0.5f, 0.5f);
        [SerializeField] private Tilemap GroundTilemap;
        [SerializeField] private Tilemap PlaceableTilemap;
        [SerializeField] private Tilemap WaterTilemap;


        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
            

                MousePos = Input.mousePosition;
                MouseInWorld = camCam.ScreenToWorldPoint(MousePos);
                WorldInCell = grid.WorldToCell(MouseInWorld);



                RaycastHit2D Hit = Physics2D.BoxCast(WorldInCell + centering, new Vector2(0.98f, 0.98f), 0f, new Vector2(0, 0));


                    if (Hit)
                    {
                        Debug.Log("GOT          HIT");
                        
                    }
                    else
                    {
                        Debug.Log("not hit");

                        GroundTilemap.SetTile(Vector3Int.FloorToInt(WorldInCell), SquarePrefab);
                    }
            }
        
        }
        
}   
