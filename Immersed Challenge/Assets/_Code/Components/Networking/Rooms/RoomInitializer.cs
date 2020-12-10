using MLAPI;
using MLAPI.Transports.UNET;
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
    [SerializeField] private GameObject _professorPrefab;
    [SerializeField] private GameObject _studentPrefab;

    private UserData _userData;

    void Awake()
    {
        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data") as UserData;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        switch (_initializationMode)
        {
            case RoomModes.Client:
                // NetworkingManager.Singleton.StartClient();
            break;
            case RoomModes.Server:
                // NetworkingManager.Singleton.StartServer();
            break;
            case RoomModes.Host:
                // NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = "127.0.0.1"; //takes string
                NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectPort = 7776;
                NetworkingManager.Singleton.StartHost();
            break;
            default:
            break;
        }

        // if (_userData.isValidated)
        // {
        //     SpawnPlayerObject();
        //     NetworkingManager.Singleton.StartClient();
        // }
    }

    public void SetRoomType(RoomModes roomMode)
    {
        _initializationMode = roomMode;
    }

    public void SpawnPlayerObject()
    {
        if (_userData.UserType == UserTypes.Professor)
        {
            GameObject go = Instantiate(_professorPrefab, Vector3.zero, Quaternion.identity);
            go.GetComponent<NetworkedObject>().SpawnAsPlayerObject(NetworkingManager.Singleton.LocalClientId);
        }
        else if (_userData.UserType == UserTypes.Student)
        {
            GameObject go = Instantiate(_studentPrefab, Vector3.zero, Quaternion.identity);
            go.GetComponent<NetworkedObject>().SpawnAsPlayerObject(NetworkingManager.Singleton.LocalClientId);
        }
    }
}
