using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carBoundsDelete : MonoBehaviour
{
    private float bounds = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > bounds) 
        { 
            Destroy(gameObject);
        } else if (transform.position.x < -bounds) 
        {
            Destroy(gameObject);
        } else if (transform.position.z > bounds) 
        {
            Destroy(gameObject);
        } else if (transform.position.z < -bounds) 
        {
            Destroy(gameObject);
        }
    }
}
