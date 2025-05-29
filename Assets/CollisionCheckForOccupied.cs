using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject code;
    public bool thing = false;

    void OnCollisionEnter()
    {
        thing = true;
        Destroy(this.gameObject);
    }
    public bool DidItHit
    {
        get
        {
            return thing;
        }
    
    
    }



    
}