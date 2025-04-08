using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class mouseinput : MonoBehaviour
{

    GridLayout gridLayout = transform.parent.GetComponent<GridLayout>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("s");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            Camera camera = Camera.main;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            float angle = Vector3.Angle(camera.transform.forward, ray.direction);
            Debug.Log((Input.mousePosition));

        }

    }
}
