using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Costume : MonoBehaviour {

    public Renderer ren;
    public ArrayList costume = new ArrayList();
    public int i = 0;

    void Start()
    {
        ren = GetComponent<Renderer>();
        costume.Add(ren.material); // dodanie dopmyslnego przebranie do puli mozliwych do wyboru
    }

    void Update()
    {
        //wybieranie przebrania
        if (Input.GetKeyDown("e"))
        {
            i++;
            if (i >= costume.Count - 1) i = costume.Count - 1;
            ren.material = (Material)costume[i];
        }
        if (Input.GetKeyDown("q"))
        {
            i--;
            if (i < 0) i = 0;
            ren.material = (Material)costume[i];
        } 
    }
}
