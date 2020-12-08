using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Room
{
    public string roomId;
    public int port;
    public string displayName;
    public string description;
    public List<string> professors;

    public class RoomCollection
    {
        public Room[] rooms;
    }
}
