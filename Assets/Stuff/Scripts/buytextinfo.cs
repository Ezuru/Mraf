using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buytextinfo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "buyTurnipTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.BuyTurnipSeeds;
        }
        if (gameObject.name == "buypotatoTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.BuyPotatoSeeds;
        }
        if (gameObject.name == "buysunflowerTxt")
        {
            GetComponent<TextMesh>().text = " " + PerScript.BuySunflowerSeeds;
        }
    }

}
