using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "User Data")]
public class UserData : ScriptableObject
{
    public string username;
    public string displayName;
    public UserTypes userType;
    public List<string> registerRooms;
}
