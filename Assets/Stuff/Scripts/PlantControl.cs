using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControl : MonoBehaviour
{
    public Sprite deadplantObj;
    public Sprite noplantObj;

    public Sprite SunflowerSeed;
    public Sprite SunflowerHalf;
    public Sprite SunflowerDone;

    public Sprite PotatoSeed;
    public Sprite PotatoHalf;
    public Sprite PotatoDone;

    public Sprite TurnipSeed;
    public Sprite TurnipHalf;
    public Sprite TurnipDone;

    public float growTime = 0;
    public float deadPlantGrowTime = 0;
    public float hoeTime = 0;

    public float growTimeHours1 = 0;
    public float growTimeMinutes1 = 0;
    public float deadPlantGrowTime1 = 0;
    public float hoeTime1 = 0;
    public float dayGrow1 = 0;
    public float dayGrowHoe1 = 0;
    public float dayGrowDead1 = 0;
    public float planted1 = 0;

    public float TurnipGrowTime = 5;
    public float potatoGrowTime = 10;
    public float sunflowerGrowTime = 2.5f;

    public Transform plotObj;
    public string water="n";

    public string currentSeed="";

    void Start()
    {
        
    }

    void Update()
    {

        //code that will replace code above
        //time for potato to grow = 8 days Turnip = 4 days sunflower = 2 days
        //weed growth = 10 days unhoe = 5 days 
        if ((currentSeed != "") && (water == "y") && (TurnipDone != GetComponent<SpriteRenderer>().sprite)
            && (PotatoDone != GetComponent<SpriteRenderer>().sprite) && (SunflowerDone != GetComponent<SpriteRenderer>().sprite))
        {
            if ((currentSeed == "Turnip") && (planted1 != 1))
            {
                //4 days
                dayGrow1 = timetextinfo.date + 4;
                planted1 = 1;
            }
            if ((currentSeed == "potato") && (planted1 != 1))
            {
                //8 days
                dayGrow1 = timetextinfo.date + 8;
                planted1 = 1;
            }
            if ((currentSeed == "sunflower") && (planted1 != 1))
            {
                //2 days
                dayGrow1 = timetextinfo.date + 2;
                planted1 = 1;
            }
        }
        else if ((currentSeed == "") && (planted1 != 1) && (noplantObj == GetComponent<SpriteRenderer>().sprite)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(173f / 255f, 107f / 255f, 42f / 255f)))
        {
            //5 days for unhoe
            dayGrow1 = timetextinfo.date + 5;
            planted1 = 1;
        }
        else if ((currentSeed == "") && (planted1 != 1) && (GetComponent<SpriteRenderer>().sprite == noplantObj)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(206f / 255f, 130f / 255f, 64f / 255f)))
        {
            //10 days for debris / weed
            dayGrow1 = timetextinfo.date + 10;
            planted1 = 1;
        }
        if ((GetComponent<SpriteRenderer>().sprite == TurnipSeed) && (water == "y") && (dayGrow1-timetextinfo.date == 2))
        {
            GetComponent<SpriteRenderer>().sprite = TurnipHalf;
        }
        if ((GetComponent<SpriteRenderer>().sprite == PotatoSeed) && (water == "y") && (dayGrow1 - timetextinfo.date == 4))
        {
            GetComponent<SpriteRenderer>().sprite = PotatoHalf;
        }
        if ((GetComponent<SpriteRenderer>().sprite == SunflowerSeed) && (water == "y") && (dayGrow1 - timetextinfo.date == 1))
        {
            GetComponent<SpriteRenderer>().sprite = SunflowerHalf;
        }
        if ((6 == timetextinfo.hour24) && (0 == timetextinfo.minutes) && (dayGrow1 == timetextinfo.date) && (water == "y") && (currentSeed == "Turnip"))
        {

            GetComponent<SpriteRenderer>().sprite = TurnipDone;
            growTimeHours1 = 25;

        }
        if ((6 == timetextinfo.hour24) && (0 == timetextinfo.minutes) && (dayGrow1 == timetextinfo.date) && (water == "y") && (currentSeed == "potato"))
        {

            GetComponent<SpriteRenderer>().sprite = PotatoDone;
            growTimeHours1 = 25;

        }
        if ((6 == timetextinfo.hour24) && (0 == timetextinfo.minutes) && (dayGrow1 == timetextinfo.date) && (water == "y") && (currentSeed == "sunflower"))
        {
            GetComponent<SpriteRenderer>().sprite = SunflowerDone;
            growTimeHours1 = 25;
        }
        if ((5 == timetextinfo.hour24) && (50 == timetextinfo.minutes) && (dayGrow1 == timetextinfo.date) && (currentSeed == "")
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(173f / 255f, 107f / 255f, 42f / 255f)))
        {
            plotObj.GetComponent<SpriteRenderer>().color = new Color(206f / 255f, 130f / 255f, 64f / 255f);
            growTimeHours1 = 25;
            planted1 = 0;
        }
        if ((6 == timetextinfo.hour24) && (00 == timetextinfo.minutes) && (dayGrow1 == timetextinfo.date) && (currentSeed == "")
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(206f / 255f, 130f / 255f, 64f / 255f)))
        {
            GetComponent<SpriteRenderer>().sprite = deadplantObj;
            growTimeHours1 = 25;
        }
    }
    void OnMouseDown()
    {
        
        if ((PerScript.CurrentTool == "Scythe") && (deadplantObj == GetComponent<SpriteRenderer>().sprite))
        {
            GetComponent<SpriteRenderer>().sprite = noplantObj;
            currentSeed = "";
            planted1 = 0;
        }
        if ((PerScript.CurrentTool == "Scythe") && (TurnipDone == GetComponent<SpriteRenderer>().sprite))
        {
            GetComponent<SpriteRenderer>().sprite = noplantObj;
            currentSeed = "";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(173f / 255f, 107f / 255f, 42f / 255f);
            water = "n";
            PerScript.Turnip++;
            planted1 = 0;
            //Debug.Log("Turnips");
        }
        if ((PerScript.CurrentTool == "Scythe") && (PotatoDone == GetComponent<SpriteRenderer>().sprite))
        {
            GetComponent<SpriteRenderer>().sprite = noplantObj;
            currentSeed = "";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(173f / 255f, 107f / 255f, 42f / 255f);
            water = "n";
            PerScript.Potatos++;
            planted1 = 0;
            //Debug.Log("potato");
        }
        if ((PerScript.CurrentTool == "Scythe") && (SunflowerDone == GetComponent<SpriteRenderer>().sprite))
        {
            GetComponent<SpriteRenderer>().sprite = noplantObj;
            currentSeed = "";
            plotObj.GetComponent<SpriteRenderer>().color = new Color(173f / 255f, 107f / 255f, 42f / 255f);
            water = "n";
            PerScript.Sunflowers++;
            planted1 = 0;
            //Debug.Log("sunflower");
        }
        if ((PerScript.CurrentTool == "Turnip") && (noplantObj == GetComponent<SpriteRenderer>().sprite) && (PerScript.TurnipSeeds > 0)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(173f / 255f, 107f / 255f, 42f / 255f)))
        {
            GetComponent<SpriteRenderer>().sprite = TurnipSeed;
            currentSeed = "Turnip";
            PerScript.TurnipSeeds -= 1;
            planted1 = 0;
            dayGrow1 = 0;
        }
        if ((PerScript.CurrentTool == "potato") && (noplantObj == GetComponent<SpriteRenderer>().sprite) && (PerScript.PotatoSeeds > 0)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(173f / 255f, 107f / 255f, 42f / 255f)))
        {
            GetComponent<SpriteRenderer>().sprite = PotatoSeed; 
            currentSeed = "potato";
            PerScript.PotatoSeeds -= 1;
            planted1 = 0;
            dayGrow1 = 0;
        }
        if ((PerScript.CurrentTool == "sunflower") && (noplantObj == GetComponent<SpriteRenderer>().sprite) && (PerScript.SunflowerSeeds > 0)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(173f / 255f, 107f / 255f, 42f / 255f)))
        {
            GetComponent<SpriteRenderer>().sprite = SunflowerSeed; 
            currentSeed = "sunflower";
            PerScript.SunflowerSeeds -= 1; 
            planted1 = 0;
            dayGrow1 = 0;
        }
        if ((PerScript.CurrentTool == "Bucket") && (GetComponent<SpriteRenderer>().sprite != noplantObj) && (GetComponent<SpriteRenderer>().sprite != deadplantObj)
            && (PerScript.WaterLevel > 0) && (water != "y") && (plotObj.GetComponent<SpriteRenderer>().color != new Color(152f / 255f, 83f / 255f, 26f / 255f)))
        {
            plotObj.GetComponent<SpriteRenderer>().color = new Color(152f / 255f, 83f / 255f, 26f / 255f);
            water = "y";
            PerScript.WaterLevel-=1;
        }
        if ((PerScript.CurrentTool == "Hoe") && (GetComponent<SpriteRenderer>().sprite == noplantObj)
            && (plotObj.GetComponent<SpriteRenderer>().color == new Color(206f / 255f, 130f / 255f, 64f / 255f)))
        {
            plotObj.GetComponent<SpriteRenderer>().color = new Color(173f / 255f, 107f / 255f, 42f / 255f);
            planted1 = 0;
        }
    }
}