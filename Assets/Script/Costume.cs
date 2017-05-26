using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Costume : MonoBehaviour {

    public Renderer ren;
    public List<Material> costume = new List<Material>();
    public int i = 0;
    CostumeGrid costumeGrid;

    void Start()
    {
        costumeGrid = GameObject.FindGameObjectWithTag("CostumeGrid").GetComponent<CostumeGrid>();
        ren = GetComponent<Renderer>();
        costume.Add(ren.material); // dodanie dopmyslnego przebranie do puli mozliwych do wyboru
    }

    void Update()
    {
        //wybieranie przebrania
        ChangeCostume();
        ImageTime[] imageTime = FindObjectsOfType<ImageTime>();
        for(int x=0,y=0;x<imageTime.Length;x++,y++)
        {
            imageTime[x].value = costume.Count - 1 - y;
        }
    }

    private void ChangeCostume()
    {
        if (Input.GetKeyDown("e"))
        {
            i++;
            costumeGrid.imageValume++;
            if (i >= costume.Count - 1)
            {
                i = costume.Count - 1;
                costumeGrid.imageValume = costumeGrid.imageCostume.Count - 1;
            }
            ren.material = (Material)costume[i];
        }
        if (Input.GetKeyDown("q"))
        {
            i--;
            costumeGrid.imageValume--;
            if (i < 0)
            {
                i = 0;
                costumeGrid.imageValume = 0;
            }
            ren.material = (Material)costume[i];
        }
    }
}
