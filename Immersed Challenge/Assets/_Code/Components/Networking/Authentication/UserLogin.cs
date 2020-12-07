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
            Professor payload = JsonUtility.FromJson<Professor>(request.downloadHandler.text);

            SceneManager.LoadScene("Office");
        }
        catch
        {
            _errorText.text = "Unable to complete login";
        }
    }

}
