using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refill : MonoBehaviour
{
    public Sprite refillWater;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
     void OnMouseDown()
    {
        if ((PerScript.CurrentTool == "Bucket") && (refillWater == GetComponent<SpriteRenderer>().sprite))
        {
            PerScript.WaterLevel = 4; 
        }
    }

}

