﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "User Data")]
public class UserData : ScriptableObject
{
    public bool isValidated;
    public string Username;
    public string DisplayName;
    public UserTypes UserType;
    public List<string> RegisterRooms;

    public void SetUserData(string username, string displayName, UserTypes userType, List<string> rooms)
    {
        isValidated = true;
        Username = username;
        DisplayName = displayName;
        UserType = userType;
        RegisterRooms = rooms;
    }
}
