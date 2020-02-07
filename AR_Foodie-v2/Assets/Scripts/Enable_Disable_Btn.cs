using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enable_Disable_Btn : MonoBehaviour
{
    public Transform btnBurger1Ing;
    public Transform btnCoffeeIng;
    public Transform btnAptIng;
    public Transform btnDntIng;
    public Transform btnBurger2Ing;
    public Transform meshBurger1Ing;
    public Transform meshCoffeeIng;
    public Transform meshApt1Ing;
    public Transform meshDntIng;
    public Transform meshBurger2Ing;
    public Transform btnHam;
    public Transform btnSalad;
    public Transform btnOfferFries;
    public Transform btnCloseOfferFries;
    public Transform btnNoHam;
    public Transform btnNoSalad;
    public Slider ingSlider;
    public Slider iceCreamSlider;
    public Transform cheese1;
    public Transform cheese2;
    public Transform iceCream1;
    public Transform iceCream2;
    
    public InputField burger1Qty;
    public InputField burger2Qty;
    public InputField coffeeQty;
    public InputField appetizerQty;
    public InputField donutQty;

    public float burger1Due;
    public float burger2Due;
    public float coffeeDue;
    public float appetizerDue;
    public float donutDue;

    float t;
    // Start is called before the first frame update
    void Start()
    {
        
        btnHam.gameObject.SetActive(true);
        btnNoHam.gameObject.SetActive(false);
        btnNoSalad.gameObject.SetActive(false);
        //btnCustomize = GetComponent<Button>();
        meshBurger1Ing.gameObject.SetActive(false);
        meshCoffeeIng.gameObject.SetActive(false);
        meshApt1Ing.gameObject.SetActive(false);
        meshDntIng.gameObject.SetActive(false);
        meshBurger2Ing.gameObject.SetActive(false);
       
        btnOfferFries.gameObject.SetActive(true);
        btnCloseOfferFries.gameObject.SetActive(false);
       

        ingSlider.minValue = 0;
        ingSlider.maxValue = 100;
        ingSlider.wholeNumbers = true;
        ingSlider.value = 50;
        cheese1.gameObject.SetActive(true);
        cheese2.gameObject.SetActive(false);

        iceCreamSlider.minValue = 0;
        iceCreamSlider.maxValue = 100;
        iceCreamSlider.wholeNumbers = true;
        iceCreamSlider.value = 50;
        iceCream1.gameObject.SetActive(true);
        iceCream2.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeOfferFriesBtn() {
        btnOfferFries.gameObject.SetActive(false);
        btnCloseOfferFries.gameObject.SetActive(true);
        this.burger1Due += 200;
    }

     public void closeNoOfferFriesBtn() {
        btnOfferFries.gameObject.SetActive(true);
        btnCloseOfferFries.gameObject.SetActive(false);
        this.burger1Due -= 200;
    }

    public void appearNoHamBtn() {
        btnNoHam.gameObject.SetActive(true);
        btnHam.gameObject.SetActive(false);
        this.burger1Due += 150;
    }

    public void appearNoSaladBtn() {
        btnNoSalad.gameObject.SetActive(true);
        btnSalad.gameObject.SetActive(false);
        this.burger1Due += 50;
    }


     public void appearHamBtn() {
        btnNoHam.gameObject.SetActive(false);
        btnHam.gameObject.SetActive(true);
        this.burger1Due -= 150;
    }

    
     public void appearSaladBtn() {
        btnNoSalad.gameObject.SetActive(false);
        btnSalad.gameObject.SetActive(true);
        this.burger1Due -= 50;
    }


    public void ViewIngredients()
    {
        meshBurger1Ing.gameObject.SetActive(true);
        meshCoffeeIng.gameObject.SetActive(true);
        meshApt1Ing.gameObject.SetActive(true);
        meshDntIng.gameObject.SetActive(true);
        meshBurger2Ing.gameObject.SetActive(true);
        btnBurger1Ing.gameObject.SetActive(false);
        btnCoffeeIng.gameObject.SetActive(false);
        btnAptIng.gameObject.SetActive(false);
        btnDntIng.gameObject.SetActive(false);
        btnBurger2Ing.gameObject.SetActive(false);
    }

    public void CloseIngredients()
    {
        meshBurger1Ing.gameObject.SetActive(false);
        meshCoffeeIng.gameObject.SetActive(false);
        meshApt1Ing.gameObject.SetActive(false);
        meshDntIng.gameObject.SetActive(false);
        meshBurger2Ing.gameObject.SetActive(false);
        btnBurger1Ing.gameObject.SetActive(true);
        btnCoffeeIng.gameObject.SetActive(true);
        btnAptIng.gameObject.SetActive(true);
        btnDntIng.gameObject.SetActive(true);
        btnBurger2Ing.gameObject.SetActive(true);
    }

    public void onValueChanged(float value)
    {
        if (value == 0)
        {
            cheese1.gameObject.SetActive(false);
            cheese2.gameObject.SetActive(false);
            iceCream1.gameObject.SetActive(false);
            iceCream2.gameObject.SetActive(false);
            this.burger1Due -= 150;
        }

        else if (value > 0 && value <= 50)
        {
            cheese1.gameObject.SetActive(true);
            cheese2.gameObject.SetActive(false);
            iceCream1.gameObject.SetActive(true);
            iceCream2.gameObject.SetActive(false);
        }

        else if (value > 50)
        {
            cheese1.gameObject.SetActive(true);
            cheese2.gameObject.SetActive(true);
            iceCream1.gameObject.SetActive(true);
            iceCream2.gameObject.SetActive(true);
            this.burger1Due += 150;
        }

    }

    public float getBurger1Tot()
    {
        float B1Tot;
        if (string.IsNullOrEmpty(burger1Qty.text))
        {
            B1Tot = this.burger1Due;
        }
        else
        {
            B1Tot = this.burger1Due * int.Parse(burger1Qty.text);
        }
        
        return B1Tot;
    }

    public float getBurger2Tot()
    {
        float B2Tot;
        if (string.IsNullOrEmpty(burger2Qty.text))
        {
            B2Tot = this.burger2Due;
        }
        else
        {
            B2Tot = this.burger2Due * int.Parse(burger2Qty.text);
        }
        
        return B2Tot;
    }

    public float getCoffeeTot()
    {
        float CoffeeTot;
        if (string.IsNullOrEmpty(coffeeQty.text))
        {
            CoffeeTot = this.coffeeDue;
        }
        else
        {
            CoffeeTot = this.coffeeDue * int.Parse(coffeeQty.text);
        }
        
        return CoffeeTot;
    }

    public float getAppetizerTot()
    {
        float AptTot;
        if (string.IsNullOrEmpty(appetizerQty.text))
        {
            AptTot = this.appetizerDue;
        }
        else
        {
            AptTot = this.appetizerDue * int.Parse(appetizerQty.text);
        }
        
        return AptTot;
    }

    public float getDonutTot()
    {
        float DonutTot;
        if (string.IsNullOrEmpty(donutQty.text))
        {
            DonutTot = this.donutDue;
        }
        else
        {
            DonutTot = this.donutDue * int.Parse(donutQty.text);
        }
        
        return DonutTot;
    }

    public InputField getQtyB1()
    {
        return this.burger1Qty;
    }
    public InputField getQtyB2()
    {
        return this.burger2Qty;
    }
    public InputField getQtyCoffee()
    {
        return this.coffeeQty;
    }
    public InputField getQtyDonut()
    {
        return this.donutQty;
    }
    public InputField getQtyApt()
    {
        return this.appetizerQty;
    }
    public void goToCart()
    {
        SceneManager.LoadScene("cart");
    }

    public float getGrandTot()
    {
        float grandTot = getBurger1Tot() + getBurger2Tot() + getCoffeeTot() + getAppetizerTot() + getDonutTot() + getGrandTot();
        return grandTot;
    }
}
