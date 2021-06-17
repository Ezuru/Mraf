using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedinfo : MonoBehaviour
{
    public Transform cursorObj;

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
        if (gameObject.name == "Turnip")
        {
            GetComponent<SpriteRenderer>().sprite = Turnip;
        }
        if (gameObject.name == "potato")
        {
            GetComponent<SpriteRenderer>().sprite = Potato;
        }
        if (gameObject.name == "sunflower")
        {
            GetComponent<SpriteRenderer>().sprite = Sunflower;
        }
    }
    void OnMouseDown()
    {
        if (gameObject.name == "Turnip")
        {
            PerScript.CurrentTool = "Turnip";
        }
        if (gameObject.name == "potato")
        {
            PerScript.CurrentTool = "potato";
        }
        if (gameObject.name == "sunflower")
        {
            PerScript.CurrentTool = "sunflower";
        }
        cursorObj.transform.position = transform.position;
    }
}
