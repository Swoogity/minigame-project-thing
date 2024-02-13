using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float hInput;
    public float vInput;
    public float jInput;
    public float speed = 10.0f;
    //public float jHeight = 1;
    public float xRange = 11;
    public float zRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player movement
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);


        vInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vInput * Time.deltaTime * speed);

        // jump
        //jInput = Input.GetAxis("Jump");
        //transform.Translate(Vector3.up * jInput * Time.deltaTime * speed);

        // player boundaries

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zRange);
        }
    }
}
