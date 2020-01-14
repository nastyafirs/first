using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{

    private string password = "qwe";
    private string login = "qwe";
    public InputField inputpassword;
    public InputField inputlogin;
    public GameObject[] imageTargets;
    public bool logged = false;
    public Image canvasBackground;
    public Text text;

    public void OnClickStart()
    {
        if (password.Equals(inputpassword.text) && login.Equals(inputlogin.text))
        {
            foreach(GameObject imageTarget in imageTargets)
            {
                imageTarget.SetActive(!imageTarget.activeSelf);
            }
            logged = true;
            canvasBackground.enabled = false;

        }
        else
        {
            ChangeText("Неверный логин или пароль!");
        }

    }

    private void ChangeText(string text)
    {
        this.text.text = text;
    }

}