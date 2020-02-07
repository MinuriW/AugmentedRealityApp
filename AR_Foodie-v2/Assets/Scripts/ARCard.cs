using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARCard : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject burgergo, beveragego, appetizergo;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour [] vrb = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for(int i = 0; i < vrb.Length; i++) {
            vrb [i].RegisterEventHandler(this);
        }
        burgergo.SetActive(false);
        beveragego.SetActive(false);
        appetizergo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
            if(vb.VirtualButtonName == "BurgerVB") {
                Debug.Log("burger button pressed");
                burgergo.SetActive(true);
                beveragego.SetActive(false);
                appetizergo.SetActive(false);
            }
            else if(vb.VirtualButtonName == "BeverageVB") {
                Debug.Log("beverage button pressed");
                burgergo.SetActive(false);
                beveragego.SetActive(true);
                appetizergo.SetActive(false);
            }
            else if(vb.VirtualButtonName == "AppetizerVB") {
                Debug.Log("appetizer button pressed");
                burgergo.SetActive(false);
                beveragego.SetActive(false);
                appetizergo.SetActive(true);
            }
            else {
              throw new UnityException(vb.VirtualButtonName  +  "Virtual Button not found!") ;
            }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

    }
}
