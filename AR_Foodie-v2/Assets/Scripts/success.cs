using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class success : MonoBehaviour
{

    public GameObject popupPanel;

    // Start is called before the first frame update
    void Start()
    {
        hidePopupPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPopupPanel() {
        popupPanel.SetActive(true);
    }

      public void hidePopupPanel() {
        popupPanel.SetActive(false);
    }


}
