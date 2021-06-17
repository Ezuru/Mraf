using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneytextinfo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Money")
        {
            GetComponent<TextMesh>().text = "$ " + PerScript.money;
        }

    }
}
