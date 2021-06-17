using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timetextinfo : MonoBehaviour
{
    public static float time = 0;
    public static int minutes = 00;
    public static int hours = 6;
    public static string day = "am";
    public static int morning = 1;
    public static int hour24 = 0;
    public static int date = 1;
    // Start is called before the first frame update
    void Start()
    {
        string minutesString = minutes.ToString("00"); //want to make it so that the player see 6:00 instead of 6:0
        hours = 5;
        hour24 = 5;
        minutes = 50; //the day starts "1 second" early as it takes that amount of time for it to "load"
        time = 9;
        GetComponent<Renderer>().sortingOrder = 6;
        GetComponent<TextMesh>().text = hours + ":" + minutesString + " " + day + " day " + date;
    }

    // Update is called once per frame
    void Update()
    {
        string minutesString = minutes.ToString("00"); //want to make it so that the player see 6:00 instead of 6:0
        GetComponent<TextMesh>().text = hours + ":" + minutesString + " " + day + " day " + date;
        time += Time.deltaTime;
        if ((time > 10) && (minutes < 60))
        {
            minutes += 10;
            time = 0;

        }
        if (minutes >= 60)
        {
            minutes = 0;
            hours += 1;
            hour24 += 1;

        }

        if (hours >= 13)
        {
            hours = 1;
        }
        if (hour24 >= 24)
        {
            hour24 = 0;
        }
        if ((hours >= 12) && (morning != 1) && (hour24 == 0))
        {
            date += 1;
            day = "am";
            morning = 1;
        }
        if ((hours >= 12) && (morning == 1) && (hour24 == 12))
        {
            day = "pm";
            morning = 0;
        }
    }
}
