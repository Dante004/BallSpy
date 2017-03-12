using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCostume : MonoBehaviour {

    Renderer ren;
    public Renderer player;

    void Start()
    {
        ren = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
    }

    public void m_CheckCostume()
    {
        if(ren.sharedMaterial == player.sharedMaterial)
        {
            return;
        }
        else
        {
            Debug.Log("Przeciwnik znalazł gracza");
        }
    }

}
