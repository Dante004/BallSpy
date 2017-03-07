using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    public Material mat;


    Renderer ren;

    private void Start()
    {
        ren = GetComponent<Renderer>();
        ren.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        sif (other.tag == "Player") other.material = ren.material;
    }


}
