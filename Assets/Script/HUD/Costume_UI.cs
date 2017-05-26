using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Costume_UI : MonoBehaviour {


    public GameObject canvas;
    public void AddCostumeToCanvas(Image ima)
    {
        Image im =  Instantiate(ima,canvas.transform.position,Quaternion.identity) as Image;
        im.transform.SetParent(canvas.transform,false);
    }
}
