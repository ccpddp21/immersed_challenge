using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomConnector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
