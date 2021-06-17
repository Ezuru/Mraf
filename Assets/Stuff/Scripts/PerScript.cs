using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerScript : MonoBehaviour
{

    public Transform LandObj;
    public Transform FloorObj;
    public static string CurrentTool = "none";
    public static int WaterLevel = 4;

    public static int SunflowerSeeds = 2;
    public static int PotatoSeeds = 0;
    public static int TurnipSeeds = 1;

    public static int Sunflowers = 0;
    public static int Potatos = 0;
    public static int Turnip = 0;

    public static int SellSunflowers = 1;
    public static int SellPotatos = 4;
    public static int SellTurnips = 2;

    public static float BuySunflowerSeeds = 0.5f;
    public static int BuyPotatoSeeds = 2;
    public static int BuyTurnipSeeds = 1;

    public static float money = 0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int xPos = -8; xPos < 10; xPos += 2)
        {
            for (int yPos = 14; yPos > -6; yPos -= 2)
            {
                Instantiate(LandObj, new Vector2(xPos, yPos), LandObj.rotation);
            }
        }
        for (int xPos = -8; xPos < 10; xPos += 2)
        {
            for (int yPos = 34; yPos > 15; yPos -= 2)
            {
                Instantiate(FloorObj, new Vector2(xPos, yPos), FloorObj.rotation);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
