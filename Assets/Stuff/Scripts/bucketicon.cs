using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketicon : MonoBehaviour
{
    public Sprite bucket;
    public Sprite bucketfull;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PerScript.WaterLevel > 0)
        {
            GetComponent<SpriteRenderer>().sprite = bucketfull;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = bucket;
        }
    }
}
