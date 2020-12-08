using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInitializer : MonoBehaviour
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

    public void SetRoomType(RoomModes roomMode)
    {
        _initializationMode = roomMode;
    }
}
