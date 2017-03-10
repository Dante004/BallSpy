using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    public Material mat;
    Costume costume;

    Renderer ren;

    private void Start()
    {
        costume = GameObject.FindGameObjectWithTag("Player").GetComponent<Costume>();
        ren = GetComponent<Renderer>();
        ren.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        costume.costume.Add(mat);
        Destroy(gameObject);
    }


}
