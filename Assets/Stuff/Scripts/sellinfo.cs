using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellinfo : MonoBehaviour
{

    public Sprite Sunflower;
    public Sprite Potato;
    public Sprite Turnip;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Turnips")
        {
            GetComponent<SpriteRenderer>().sprite = Turnip;
        }
        if (gameObject.name == "potatos")
        {
            GetComponent<SpriteRenderer>().sprite = Potato;
        }
        if (gameObject.name == "sunflowers")
        {
            GetComponent<SpriteRenderer>().sprite = Sunflower;
        }
    }
    void OnMouseDown()
    {
        if ((gameObject.name == "Turnips") && (PerScript.Turnip > 0))
        {
            PerScript.money += 2;
            PerScript.Turnip -= 1;
        }
        if ((gameObject.name == "potatos") && (PerScript.Potatos > 0))
        {
            PerScript.money += 4;
            PerScript.Potatos -= 1;
        }
        if ((gameObject.name == "sunflowers") && (PerScript.Sunflowers > 0))
        {
            PerScript.money += 1;
            PerScript.Sunflowers -= 1;
        }
    }
}
