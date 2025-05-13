using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
  
    
    void Update()
    {
        transform.position = new Vector3(player.position.x , player.position.y, offset.z); // Camera follows the player with specified offset position
        
    }
}
