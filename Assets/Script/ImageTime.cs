using UnityEngine;
using UnityEngine.UI;

public class ImageTime : MonoBehaviour {

    Image myImage;
    float time;
    Costume costume;
    public int value;
    CostumeGrid costumegrid;

	void Start ()
    {
        costumegrid = FindObjectOfType<CostumeGrid>();
        costume = GameObject.FindGameObjectWithTag("Player").GetComponent<Costume>();
        myImage = gameObject.GetComponent<Image>();
	}
	
	void Update ()
    {


        if(value==costume.i && value==costumegrid.imageValume)
        {
            if (FindObjectOfType<PlayerMovement>().move)
            {
                time = (float)0.10 * Time.deltaTime;
            }
            else
            {
                time = (float)0.025 * Time.deltaTime;
            }

            myImage.fillAmount -= time;
        }
        if(myImage.fillAmount <= 0)
        {
            costume.costume.RemoveAt(costume.i);
            costumegrid.imageCostume.RemoveAt(FindObjectOfType<CostumeGrid>().imageValume);
            costumegrid.imageValume--;
            costume.ren.material = (Material)costume.costume[0];
            costume.i = 0;
            costumegrid.imageValume = 0;
            Destroy(gameObject);
        }
	}
}
