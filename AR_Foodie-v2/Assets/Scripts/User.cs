using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User 
{
    public string userName;
    public string password;
    public string email;
    public string contactNo;
    public string localId;


    public User(){
        userName = loginPage.userName;
        password = loginPage.passWord;
        email = loginPage.email;
        contactNo = loginPage.contactNo;
       // localId = loginPage.localId;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
