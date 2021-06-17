using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenControlhouse : MonoBehaviour
{
    public Transform camObj;
    public Transform timeObj;
    public Transform moneyObj;

    void OnMouseDown()
    {

        if (gameObject.name == "wnarrow (1)1)")
            {
                //SceneManager.LoadScene("upper farm");
                camObj.transform.position = new Vector3(0f, 10f, -10f);
                timeObj.transform.position = new Vector2(-6.25f, 13.5f);
                moneyObj.transform.position = new Vector2(-6.25f, 14.5f);
            }
        if (gameObject.name == "bed")
        {
            timetextinfo.hours = 5;
            timetextinfo.hour24 = 5;
            timetextinfo.minutes = 50;
            timetextinfo.time = 9;
            timetextinfo.date += 1;
            camObj.transform.position = new Vector3(0f, 30f, -10f);
            timeObj.transform.position = new Vector2(-6.25f, 33.5f);
            moneyObj.transform.position = new Vector2(-6.25f, 34.5f);
        }
    }
}
