using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selltextinfo : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "TurnipTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.SellTurnips;
        }
        if (gameObject.name == "potatosTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.SellPotatos;
        }
        if (gameObject.name == "sunflowersTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.SellSunflowers;
        }
    }

}
