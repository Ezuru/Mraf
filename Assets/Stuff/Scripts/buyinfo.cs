using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyinfo : MonoBehaviour
{
    public Sprite sunflower;
    public Sprite potato;
    public Sprite Turnip;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "BuyTurnip")
        {
            GetComponent<SpriteRenderer>().sprite = Turnip;
        }
        if (gameObject.name == "buypotato")
        {
            GetComponent<SpriteRenderer>().sprite = potato;
        }
        if (gameObject.name == "buysunflower")
        {
            GetComponent<SpriteRenderer>().sprite = sunflower;
        }
    }
    void OnMouseDown()
    {
        if ((gameObject.name == "BuyTurnip") && (PerScript.money > 0))
        {
            PerScript.money -= 1;
            PerScript.TurnipSeeds += 1;
        }
        if ((gameObject.name == "buypotato") && (PerScript.money > 0))
        {
            PerScript.money -= 2;
            PerScript.PotatoSeeds += 1;
        }
        if ((gameObject.name == "buysunflower") && (PerScript.money > 0))
        {
            PerScript.money -= 1/2f;
            PerScript.SunflowerSeeds += 1;
        }
    }
}
