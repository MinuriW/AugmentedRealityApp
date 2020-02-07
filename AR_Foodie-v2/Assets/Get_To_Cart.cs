using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_To_Cart : MonoBehaviour
{
    public InputField burger1Qty;
    public InputField burger2Qty;
    public InputField coffeeQty;
    public InputField appetizerQty;
    public InputField donutQty;

    Enable_Disable_Btn btnObj = new Enable_Disable_Btn();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(btnObj.getQtyB1());
        burger1Qty = btnObj.getQtyB1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public InputField getQtyB1()
    {
        return btnObj.getQtyB1();
    }
    public InputField getQtyB2()
    {
        return btnObj.getQtyB2();
    }
    public InputField getQtyCoffee()
    {
        return btnObj.getQtyCoffee();
    }
    public InputField getQtyDonut()
    {
        return btnObj.getQtyDonut();
    }
    public InputField getQtyApt()
    {
        return btnObj.getQtyApt();
    }
}
