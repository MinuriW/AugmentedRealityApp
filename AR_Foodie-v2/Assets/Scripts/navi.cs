using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount >0 && Input.)
        //{

        //}
        
    }

        public void goToMainMenu() {

    
          SceneManager.LoadScene("mainMenu");
    }

    public void goToHome() {

    
          SceneManager.LoadScene("ARFoodApp");
    }

    public void goToPreviousOrders()
    {
        SceneManager.LoadScene("previousOrders");
    }

    public void goToOrderDetails()
    {
        SceneManager.LoadScene("orderDetails");
    }

    public void goToBeveragesMenu() {
         SceneManager.LoadScene("beverageMenu");
    }

    public void fromBeverageMenuToMainMenu() {
         SceneManager.LoadScene("mainMenu");
    }
     public void goToBurgersMenu() {
         SceneManager.LoadScene("burgerMenu");
    }

     public void goToMostPopularMenu() {
         SceneManager.LoadScene("mostPopMenu");
    }

     public void goToSingleFoodItem() {
         SceneManager.LoadScene("singeFoodItem");
    }

    public void goToCart() {
         SceneManager.LoadScene("cart");
    }

    public void goToPaymentMethods() {
         SceneManager.LoadScene("payment");
    }

     public void goToPaypal() {
          Application.OpenURL("https://www.paypal.com/bt/signin");
    }

     public void goToCard() {
         SceneManager.LoadScene("card");
    }


    public void goToMainScene() {
         SceneManager.LoadScene("LoginPage");
    }

     public void goToLogin() {
         SceneManager.LoadScene("LoginPage");
    }

    public void goToRegister() {
         SceneManager.LoadScene("RegPage");
    }

     public void goToCustomize() {
         SceneManager.LoadScene("customize");
    }

     public void goToPromotions()
     {
         SceneManager.LoadScene("PromoDetail");
     }
}
