using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textinfo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "TurnipTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.TurnipSeeds;
        }
        if (gameObject.name == "potatoTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.PotatoSeeds;
        }
        if (gameObject.name == "sunflowerTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.SunflowerSeeds;
        }
    }

}