using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenControlUpperFarm : MonoBehaviour
{
    public Transform camObj;
    public Transform timeObj;
    public Transform moneyObj;

    void OnMouseDown()
    {
        if (gameObject.name == "downarrow")
        {
            //SceneManager.LoadScene("upper farm");
            camObj.transform.position = new Vector3(0f, 0f, -10f);
            timeObj.transform.position = new Vector2(-6.25f, 3.5f);
            moneyObj.transform.position = new Vector2(-6.25f, 4.5f);
        }
        if (gameObject.name == "house")
        {
            camObj.transform.position = new Vector3(0f, 20f, -10f);
            timeObj.transform.position = new Vector2(-6.25f, 23.5f);
            moneyObj.transform.position = new Vector2(-6.25f, 24.5f);
        }

    }

}
