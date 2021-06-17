using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "waterlevel")
        {
            GetComponent<TextMesh>().text = " " + PerScript.WaterLevel;
        }
    }
}
