using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostumeGrid : MonoBehaviour {

    public int col, row;
    RectTransform rt;
    GridLayoutGroup grid;
    public int imageValume = 0;
    public List<Image> imageCostume = new List<Image>();
    public Image defaultimage;
    

	void Start ()
    {
        imageCostume.Add(defaultimage);
        rt = gameObject.GetComponent<RectTransform>();
        grid = gameObject.GetComponent<GridLayoutGroup>();
	}
	

	void Update ()
    {
        grid.cellSize = new Vector2(rt.rect.width/col,rt.rect.height/row);
	}
}
