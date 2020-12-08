using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using TMPro;

public class UserLogin : MonoBehaviour
{
    [SerializeField] private TMP_InputField _usernameInput;
    [SerializeField] private TMP_InputField _passwordInput;
    [SerializeField] private TextMeshProUGUI _errorText;

    void Start()
    {
        _errorText.text = "";
    }

    public void Login()
    {
        StartCoroutine(Authenticate());
    }

    public IEnumerator Authenticate()
    {
        UnityWebRequest request = UnityWebRequest.Get(string.Format("http://localhost:3000/auth/login?username={0}&password={1}", _usernameInput.text, _passwordInput.text));
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();
       
        try
        {
            Player player = JsonUtility.FromJson<Player>(request.downloadHandler.text);

            UserData userData = Resources.Load("ScriptableObjects/User Data") as UserData;
            userData.SetUserData(player.username, player.displayName, (UserTypes)Enum.Parse(typeof(UserTypes), player.userType, true), player.registeredRooms);

            if (userData.UserType == UserTypes.Professor)
                SceneManager.LoadScene("Office");
            else if (userData.UserType == UserTypes.Student)
                SceneManager.LoadScene("Personal");
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
            _errorText.gameObject.transform.parent.gameObject.SetActive(true);
            _errorText.text = "Unable to complete login";
        }
    }

}
