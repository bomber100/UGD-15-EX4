using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

    public float speed;
//<<<<<< HEAD
    public float jump;
//=======
//>>>>>>> b1e36a1871bb26ec8bd9f78debf7b4647705194b
    private Rigidbody rb;
	
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	}
//<<<<<<< HEAD
//=======
    private void Update()
    {
        
    }
//>>>>>>> b1e36a1871bb26ec8bd9f78debf7b4647705194b
}
