using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager Singleton;

    [SerializeField] private UserData _userData;
    // Start is called before the first frame update
    void Awake()
    {
        Singleton = this;

        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data") as UserData;
        }
    }

    public void SetUserData(string username, string displayName, UserTypes userType, List<string> rooms)
    {
        _userData.username = username;
        _userData.displayName = displayName;
        _userData.userType = userType;
        _userData.registerRooms = rooms;
    }
}
