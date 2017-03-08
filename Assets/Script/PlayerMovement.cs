using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public float maxSpeed = 10;
    public float minSpeed = 3;
    public float normalSpeed = 5;

    private Rigidbody rb; 
	
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        speed = normalSpeed;
	}

    void Update()
    {
        if (Input.GetButton("Fire1")) speed = maxSpeed;
        if (Input.GetButton("Fire2")) speed = minSpeed;
        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Fire2")) speed = normalSpeed;


    }


    void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        rb.velocity = movement * speed;	
	}

}
