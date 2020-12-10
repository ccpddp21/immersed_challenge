using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerConnection : MonoBehaviour
{
    private RoomConnector _roomConnector;
    private UserData _userData;

    // Start is called before the first frame update
    void Start()
    {
        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data")as UserData;
        }

        _roomConnector = GameObject.FindGameObjectWithTag("Room Manager").GetComponent<RoomConnector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeaveRoom()
    {
        _roomConnector.LeaveRoom(this.GetComponent<NetworkedObject>().NetworkId);

        if (_userData.UserType == UserTypes.Professor)
            SceneManager.LoadScene("Office");
        else if (_userData.UserType == UserTypes.Student)
            SceneManager.LoadScene("Personal");
    }
}
