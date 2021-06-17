using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuTextInfo : MonoBehaviour
{
    public Transform camObj;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Start")
        {
            GetComponent<TextMesh>().text = "Start";
        }
        if (gameObject.name == "Instructions")
        {
            GetComponent<TextMesh>().text = "Instructions";
        }
        if (gameObject.name == "Quit")
        {
            GetComponent<TextMesh>().text = "Quit";
        }
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "Start")
        {
            SceneManager.LoadScene("Mraf");
        }
        if (gameObject.name == "Instructions")
        {
            camObj.transform.position = new Vector3(0f, -5f, -10f);
        }
        if (gameObject.name == "Quit")
        {
            Application.Quit();
        }
        if (gameObject.name == "uparrow")
        {
            camObj.transform.position = new Vector3(0f, 5f, -10f);
        }
        if (gameObject.name == "Down")
        {
            camObj.transform.position = new Vector3(0f, -15f, -10f);
            Debug.Log("I'mk working");
        }
    }
}
