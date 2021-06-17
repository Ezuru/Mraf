using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class croptextinfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "TurnipsTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.Turnip;
        }
        if (gameObject.name == "potatosTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.Potatos;
        }
        if (gameObject.name == "sunflowersTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.Sunflowers;
        }
    }

}