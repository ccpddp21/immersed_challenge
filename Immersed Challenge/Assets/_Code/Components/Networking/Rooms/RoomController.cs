using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public enum RoomModes
    {
        Client,
        Host,
        Server
    }

    [SerializeField] private RoomModes _initializationMode;

    // Start is called before the first frame update
    void Start()
    {
        switch (_initializationMode)
        {
            case RoomModes.Client:
                NetworkingManager.Singleton.StartClient();
            break;
            case RoomModes.Server:
                NetworkingManager.Singleton.StartServer();
            break;
            case RoomModes.Host:
                NetworkingManager.Singleton.StartHost();
            break;
            default:
            break;
        }
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
}
