using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenControlMraf : MonoBehaviour
{
    public Transform camObj;
    public Transform timeObj;
    public Transform moneyObj;

    void OnMouseDown()
    {
        if (gameObject.name == "uparrow")
        {
            //SceneManager.LoadScene("upper farm");
            camObj.transform.position = new Vector3(0f, 10f, -10f);
            timeObj.transform.position = new Vector2(-6.25f, 13.5f);
            moneyObj.transform.position = new Vector2(-6.25f, 14.5f);
        }

    }
}
