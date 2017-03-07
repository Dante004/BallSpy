using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public float maxSpeed = 10;
    public float minSpeed = 3;

    private Rigidbody rb; 
	
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    void Update()
    {
        if (Input.GetButton("Fire1")) Run();
        if (Input.GetButton("Fire2")) Slow();
        if (Input.GetButtonUp("Fire1") || Input.GetButtonUp("Fire2")) speed = 5;


    }


    void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        rb.velocity = movement * speed;	
	}

    void Run()
    {
        speed = maxSpeed;
    }

    void Slow()
    {
        speed = minSpeed;
    }
}
