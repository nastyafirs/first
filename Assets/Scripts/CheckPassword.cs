using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{

    private string password = "qwe";
    public InputField inputField;

    public void OnClickStart()
    {
        if (password.Equals(inputField.text)){
            Debug.Log("Password is ok");
        }

    }
}