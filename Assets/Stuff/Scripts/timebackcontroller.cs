using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timebackcontroller : MonoBehaviour
{
    public Transform camObj;
    public Transform timeObj;
    public Transform moneyObj;
    public float counter = 1;
    private float fadePerSecond = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (camObj.transform.position == new Vector3(0f, 30f, -10f))
        {
            counter = counter - (fadePerSecond * Time.deltaTime);
            var material = GetComponent<Renderer>().material;
            var color = material.color;

            material.color = new Color(color.r, color.g, color.b, color.a - (fadePerSecond * Time.deltaTime));
            if (counter <= 0)
            {
                camObj.transform.position = new Vector3(0f, 20f, -10f);
                timeObj.transform.position = new Vector2(-6.25f, 23.5f);
                moneyObj.transform.position = new Vector2(-6.25f, 24.5f);
                material.color = new Color(color.r, color.g, color.b, 1);
                counter = 1;
            }
        }
    }
}
