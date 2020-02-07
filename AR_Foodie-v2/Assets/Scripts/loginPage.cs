using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine.SceneManagement;

public class loginPage : MonoBehaviour
{
    public InputField NameInput;
    public InputField PasswordInput;
    public InputField EmailInput;
    public InputField  ContactInput;
    public InputField InputFieldEdit;

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
    void Start()
    {
        
    }
    public void OnSubmit() {
        userName = NameInput.text;
        passWord = PasswordInput.text;
        email = EmailInput.text;
        contactNo = ContactInput.text;
        PostToDatabase();
        //RetreiveFromDB();
        SceneManager.LoadScene("LoginScene");
    }

    public void OnViewProf() {
      //  EditProf.Name.text = RetreiveFromDB().userName.ToString;
        RetreiveFromDB();
        SceneManager.LoadScene("ViewPorfScene");
    }

    public void OnBackView()
    {
        //  EditProf.Name.text = RetreiveFromDB().userName.ToString;
        RetreiveFromDB();
        SceneManager.LoadScene("ViewPorfScene");
    }

    public void OnEditProf()
    {
        //  EditProf.Name.text = RetreiveFromDB().userName.ToString;
        RetreiveFromDB();
        SceneManager.LoadScene("EditProfScene");
    }

    private void UpdateName() {
        nameTxt = user.userName;
        pw = user.password;
        em = user.email;
        con = user.contactNo;
       // InputFieldEdit.text = user.userName;
    }
    private void PostToDatabase() {
        User user = new User();        
        RestClient.Put("https://loginex-12.firebaseio.com/"+ userName +".json", user);
    }

    private void RetreiveFromDB() {
        RestClient.Get<User>("https://loginex-12.firebaseio.com/" + userName + ".json").Then(response =>
        {
            user = response;
            UpdateName();
        });
        
    }
    public void SignOutUser()
    {
        SignOut();
        SceneManager.LoadScene("LoginScene");

    }
    void SignOut() { }
    // Update is called once per frame
    void Update()
    {
        
    }
}
