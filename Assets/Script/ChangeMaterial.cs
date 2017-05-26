using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour {

    public Material mat;
    Costume costume;
    public Image image;
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
        FindObjectOfType<CostumeGrid>().imageCostume.Add(image);
        FindObjectOfType<Costume_UI>().AddCostumeToCanvas(image);
        Destroy(gameObject); //zniszczenie obiektu który daje nam nowe przebranie
    }


}
