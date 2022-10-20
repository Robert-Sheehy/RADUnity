using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    float speed = 10f;
    float rotationSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) )
        {
            transform.position += speed* transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.forward, rotationSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.forward, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(transform.right, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(transform.right, -rotationSpeed * Time.deltaTime);
        }


    }
}
