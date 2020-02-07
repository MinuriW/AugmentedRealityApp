using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Register : MonoBehaviour
{
    public GameObject username;
    public GameObject email;
    public GameObject contactno;
    private string Name;
    private string Email;
    private string ConNum;
     private string form;
     private bool EmailValid = false;
    private String[] Characters = {"a","b","c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                    "1", "2", "3", "4", "5", "6", "7", "8", "9","0","_","-" };

    // Start is called before the first frame update
    void Start()
    {

    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void RegisterButton() {
      
        bool UN = false;
        bool CN = false;
        bool EM = false;
        if (Name != "")
        {
            UN = true;
        }
        else {
            Debug.LogWarning("Name field is empty");
        }
        if (ConNum != "")
        {
            if (!System.IO.File.Exists(@"C:/UnityTestFolder/" + ConNum + ".txt"))
            {
                if (ConNum.Length == 10)
                {
                    CN = true;
                }
                else {
                    Debug.LogWarning("Contact number is less than 10 digits");
                }
            }
            else
            {
                Debug.LogWarning("Already this number is registered");
            }
        }
        else {
            Debug.LogWarning("Contact Number filed is empty");
        }
        if (Email != "")
        {
            EmailValidation();
            if (EmailValid)
            {
                if (Email.Contains("@"))
                {
                    if (Email.Contains("."))
                    {
                        EM = true;
                    }
                    else
                    {
                        Debug.LogWarning("Email is incorrect");
                    }
                }
                else
                {
                    Debug.LogWarning("Email is incorrect");
                }
            }
            else {
                Debug.LogWarning("Email is incorrecrt");
            }
        }
        else {
            Debug.LogWarning("Email Field is empty");
            
        }

        if (UN == true && EM == true && CN == true) {
         
            form = (Name + Environment.NewLine + ConNum + Environment.NewLine + Email);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + ConNum + ".txt", form);
            username.GetComponent<InputField>().text = "";
            email.GetComponent<InputField>().text = "";
            contactno.GetComponent<InputField>().text = "";
            print("Registration Complete");
            SceneManager.LoadScene("LoginPage");
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                contactno.GetComponent<InputField>().Select();
            }
            if (contactno.GetComponent<InputField>().isFocused)
            {
                email.GetComponent<InputField>().Select();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (Name != "" && Email != "" && ConNum != "") {
                RegisterButton();
            }
        }
        Name = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        ConNum = contactno.GetComponent<InputField>().text;

    }
    void EmailValidation() {
        bool SW = false;
        bool EW = false;
        for (int i = 0; i < Characters.Length; i++) {
            if (Email.StartsWith(Characters[i])) {
                SW = true;
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.EndsWith(Characters[i]))
            {
                EW = true;
            }
        }
        if (SW == true && EW == true)
        {
            EmailValid = true;
        }
        else {
            EmailValid = false;
        }
    }
}
