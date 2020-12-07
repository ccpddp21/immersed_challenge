using System.Collections.Generic;

[System.Serializable]
public abstract class Player
{
    public string username;
    public string displayName;
    public string userType;
    public List<string> registeredRooms;
}