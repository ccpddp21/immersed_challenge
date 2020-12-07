using System.Collections.Generic;

public class Professor : Player
{
    public override string ToString()
    {
        string str = string.Format("{0} {1} {2} {3}", username, displayName, userType, registeredRooms);
        return str;
    }
}