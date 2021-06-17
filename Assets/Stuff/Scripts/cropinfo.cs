using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cropinfo : MonoBehaviour
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
}
