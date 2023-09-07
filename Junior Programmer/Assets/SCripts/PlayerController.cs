using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnSpeed =45.0f;
    private float HorizontalSpeed;
    private float forw;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        HorizontalSpeed = Input.GetAxis("Horizontal");
        forw= Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime* speed* forw);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*HorizontalSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*HorizontalSpeed);
    }
}
