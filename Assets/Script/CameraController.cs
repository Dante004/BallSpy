using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 velocity;
    public float smoothTimeX, smoothTimeZ;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x,smoothTimeX);
        float posZ = Mathf.SmoothDamp(transform.position.z, player.transform.position.z, ref velocity.z, smoothTimeZ);

        transform.position = new Vector3(posX, transform.position.y, posZ);
    }
}
