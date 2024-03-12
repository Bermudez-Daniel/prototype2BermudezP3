using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float xRange = 10;
    public float horizontalInput;
    public float speed = 10.0f;
    
    // Update is called once per frame
    void Update()
    {
        
        
        if (transform.position.x < xRange)

        {
          transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }
    }
}
