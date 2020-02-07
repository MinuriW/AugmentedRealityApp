using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine.SceneManagement;

public class EditProf : MonoBehaviour
{
    public InputField Name;
    public InputField InputFieldPW;
    public InputField InputFieldEmail;
    public InputField InputFieldNo;

    //public static string userName;
    User user = new User();
    public static string userName;
    public static string passWord;
    public static string email;
    public static string contactNo;
    public static string nameTxt;
    public static string pw;
    public static string em;
    public static string con;
    // Start is called before the first frame update
   
    public void OnSubmit()
    {
        userName = Name.text;
        passWord = InputFieldPW.text;
        email = InputFieldEmail.text;
        contactNo = InputFieldNo.text;
        PostToDatabase();
        RetreiveFromDB();
        SceneManager.LoadScene("ViewPorfScene");
    }

    private void UpdateName()
    {
        nameTxt = user.userName;
        pw = user.password;
        em = user.email;
        con = user.contactNo;
        // InputFieldEdit.text = user.userName;
    }
    private void PostToDatabase()
    {
        User user = new User();
        RestClient.Put("https://loginex-12.firebaseio.com/" + userName + ".json", user);
    }

    private void RetreiveFromDB()
    {
        RestClient.Get<User>("https://loginex-12.firebaseio.com/" + userName + ".json").Then(response =>
        {
            user = response;
            UpdateName();
        });

    }
    public void BackToEdit() {
        SceneManager.LoadScene("EditProfScene");
    }
    // Start is called before the first frame update
    void Start()
    {
       // userName = loginPage.nameTxt.ToString();
        Name.text = loginPage.nameTxt;
        InputFieldPW.text = loginPage.pw;
        InputFieldEmail.text = loginPage.em;
        InputFieldNo.text = loginPage.con; 
       // Name.text = "hi";
    }
    public void OnBack() {
        SceneManager.LoadScene("navigationScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
