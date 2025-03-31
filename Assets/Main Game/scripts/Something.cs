using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D _rb;
    float _walkspeed;
    float _inputhorizontal;
    float _inputvertical;


    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _walkspeed = 664f;

    }

    // Update is called once per frame
    void Update()
    {
        _inputhorizontal = Input.GetAxis("Horizontal");
        _inputvertical = Input.GetAxis("Vertical");

        if (_inputhorizontal != 0)
        {
            _rb.AddForce(new Vector2((_inputhorizontal * _walkspeed) * Time.deltaTime, 0f));
        }
        if (_inputvertical != 0)
        {
            _rb.AddForce(new Vector2(0f, (_inputvertical * _walkspeed) * Time.deltaTime));
        }
    }
}
