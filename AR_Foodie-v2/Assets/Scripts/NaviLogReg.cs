using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaviLogReg : MonoBehaviour
{
    public string GoToLoginPage;
    public string GoToRegPage;
    public void goToLoginPage()
    {

        SceneManager.LoadScene(GoToLoginPage);
    }

    public void goToRegister()
    {
        SceneManager.LoadScene(GoToRegPage);
    }

}