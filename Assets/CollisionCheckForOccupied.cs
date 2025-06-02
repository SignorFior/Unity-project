using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public bool touched = false;
    public GameObject toDestroy;
    private void Awake()
    {
        Debug.Log("i appeared");
    }
    void OnCollisionStay2D()
    {
        touched = true;
        Debug.Log("Destroyng by OnCollisionStay2D");
        Destroy(toDestroy);

    }
    public bool DidItHit
    {
        get
        {
            Debug.Log("returning touched" + touched);
            return touched;
        }
        set
        {
            Debug.Log("Destroyng by set from didithit");
            Destroy(toDestroy);
        }
    
    }



    
}