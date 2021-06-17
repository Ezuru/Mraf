using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupables : MonoBehaviour
{

    public Transform cursorObj;
    public Transform seedInvObj;
    public Transform InvObj;
    public Transform SellObj;
    public Transform BuyObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name == "scythe")
        {
            PerScript.CurrentTool = "Scythe";
            seedInvObj.transform.position = new Vector2(12f, -0.6f);
            InvObj.transform.position = new Vector2(12f, 5.6f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 0 boxes
        }
        else if (gameObject.name == "seeds") 
        {
            //PerScript.currentTool = "Seeds";
            seedInvObj.transform.position = new Vector2(7.1f, -4f);
            InvObj.transform.position = new Vector2(12f, 5.6f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 01 boxes seedInvObj
        }
        else if (gameObject.name == "bucket")
        {
            PerScript.CurrentTool = "Bucket";
            seedInvObj.transform.position = new Vector2(12f, -0.6f);
            InvObj.transform.position = new Vector2(12f, 5.6f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 0 boxes
        }
        else if (gameObject.name == "Inventory")
        {
            PerScript.CurrentTool = "Inventory";
            InvObj.transform.position = new Vector2(7.1f, 4f);
            seedInvObj.transform.position = new Vector2(12f, -0.6f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 1 boxes InvObj
        }
        else if (gameObject.name == "Sell")
        {
            PerScript.CurrentTool = "Sell";
            InvObj.transform.position = new Vector2(3.9f, 4f);
            seedInvObj.transform.position = new Vector2(12f, -0.6f);
            SellObj.transform.position = new Vector2(7.1f, 4f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 2 boxes SellObj, InvObj
        }
        else if (gameObject.name == "Buy")
        {
            PerScript.CurrentTool = "Buy";
            InvObj.transform.position = new Vector2(12f, 5.6f);
            seedInvObj.transform.position = new Vector2(7.1f, -4f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(7.1f, 4f);
            //brings up 2 boxes BuyObj, seedInvObj
        }
        else if (gameObject.name == "Hoe")
        {
            PerScript.CurrentTool = "Hoe";
            seedInvObj.transform.position = new Vector2(12f, -0.6f);
            InvObj.transform.position = new Vector2(12f, 5.6f);
            SellObj.transform.position = new Vector2(12, 3.6f);
            BuyObj.transform.position = new Vector2(12, 1.6f);
            //brings up 0 boxes
        }
        cursorObj.transform.position = transform.position;
    }
}
