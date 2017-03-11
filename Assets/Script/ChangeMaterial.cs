using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    public Material mat;
    Costume costume;

    Renderer ren;

    private void Start()
    {
        costume = GameObject.FindGameObjectWithTag("Player").GetComponent<Costume>(); // dostep do komponetyów Playera
        ren = GetComponent<Renderer>();
        ren.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        costume.costume.Add(mat); //dodane przebranie do puli mozliwych do wyboru
        Destroy(gameObject); //zniszczenie obiektu który daje nam nowe przebranie
    }


}
