using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomConnector : MonoBehaviour
{
    /// Join Room by roomId
    public void JoinRoom(string roomId = "")
    {
        NetworkingManager.Singleton.StartClient();
    }

    /// (Testing) Start a hosted room
    public void HostRoom()
    {
        NetworkingManager.Singleton.StartHost();
    }

    public void SendRoomInvite()
    {

    }

    /// Kick a user from hosted Room
    public void KickUser(string userId)
    {
        // Send HTTP request to Rooms API
    }

    /// Kick multiple users from hosted Room
    public void KickUsers(string[] userIds)
    {
        for (int i = 0; i < userIds.Length; i++)
        {
            KickUser(userIds[i]);
        }
    }

    /// Block a user's access to hosted Room
    public void BlockUser(string userId)
    {
        // Send HTTP request to Rooms API
    }

    /// Block multiple users' access to hosted Room
    public void BlockUsers(string[] userIds)
    {
        for (int i = 0; i < userIds.Length; i++)
        {
            BlockUser(userIds[i]);
        }
    }

    public void LeaveRoom(ulong clientId)
    {
        NetworkingManager.Singleton.DisconnectClient(clientId);
    }
}
