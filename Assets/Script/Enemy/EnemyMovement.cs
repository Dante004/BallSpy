using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Vector3 q_from = new Vector3(0.0F, -30.0F, 0.0F);
    public Vector3 q_to = new Vector3(0.0F, -150.0F, 0.0F);
    public Vector3 r_to = new Vector3(0,0,0);
    Vector3 r_from;
    Vector3 to1;
    public float q_frequency = 0.5F;
    public float r_frequency = 0.5F;
    public bool isMovement, isRotate;

    void Start()
    {
        r_from = new Vector3(transform.position.x,0.5f,transform.position.z);
        to1 = new Vector3(transform.position.x+r_to.x, 0.5f, transform.position.z+r_to.z);
    }

    void Update ()
    { 
        Quaternion from = Quaternion.Euler(q_from);
        Quaternion to = Quaternion.Euler(q_to);
        float q_lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.q_frequency));
        float r_lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.r_frequency));

        if(isRotate)
        transform.localRotation = Quaternion.Lerp(from, to, q_lerp);

        if(isMovement)
        transform.position = Vector3.Lerp(r_from,to1,r_lerp);
    }
}
