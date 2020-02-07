using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine.SceneManagement;

public class log : MonoBehaviour
{
    public InputField PasswordInput;
    public InputField ContactInput;

    User user = new User();
    public static string contactNo;
    public static string passWord;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnNavigateToDetails()
    {
        SceneManager.LoadScene("RegisterScene");
    }

    public void OnSubmitDetails()
    {
        SceneManager.LoadScene("navigationScene");
//SignInUser(contactno, password);
    }


  //  private void SignInUser(string contactno, string password)
//{
    //    string userData = "{\"contactno\":\"" + contactno + "\",\"password\":\"" + password + "\",\"returnSecureToken\":true}";
    //    RestClient.Post<SignResponse>("https://www.googleapis.com/identitytoolkit/v3/relyingparty/verifyPassword?key=" + AuthKey, userData).Then(
//response =>
  //          {
    //            idToken = response.idToken;
    //            localId = response.localId;

     //       }).Catch(error =>
      //      {
     //           Debug.Log(error);
      //      });
  //  }
}
