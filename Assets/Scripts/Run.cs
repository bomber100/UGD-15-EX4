using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

    public float speed = 30;

    public float jump = 4;
    private Rigidbody rb;
    Vector3 jumpDirection = new Vector3(0.0f, 1.0f, 0.0f);
    void Start () {
        
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(jumpDirection * jump);
        }
    }
}
