using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RoomSearcher : MonoBehaviour
{
    [SerializeField] private UserData _userData;
    [SerializeField] private RoomMenuController _roomMenuController;

    void Awake()
    {
        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data") as UserData;
        }
    }

    void Start()
    {
        GetRegisteredRooms();
    }

    public void FindAllPublicRooms()
    {
        StartCoroutine(AllPublicRoomsCoroutine());
    }

    /// Retrive data for list of all active [public] Rooms
    public IEnumerator AllPublicRoomsCoroutine()
    {
        // Send HTTP request to Rooms API
        UnityWebRequest request = UnityWebRequest.Get(string.Format("http://localhost:3000/rooms/public"));
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();

        try
        {
            RoomCollection rooms = JsonUtility.FromJson<RoomCollection>(request.downloadHandler.text);
            Debug.Log(rooms.rooms.Count);
            _roomMenuController.AddEntries(rooms.rooms.ToArray());
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public void GetRegisteredRooms()
    {
        StartCoroutine(RegisteredRoomsCoroutine());
    }

    /// Retrive data for all Rooms the User is associated 
    public IEnumerator RegisteredRoomsCoroutine()
    {
        // Send HTTP request to Rooms API
        UnityWebRequest request = UnityWebRequest.Get(string.Format("http://localhost:3000/rooms/registered?roomIds=[{0}]", string.Join(", ", _userData.RegisterRooms.ToArray())));
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();

        try
        {
            RoomCollection rooms = JsonUtility.FromJson<RoomCollection>(request.downloadHandler.text);
            Debug.Log("h");
            _roomMenuController.AddEntries(rooms.rooms.ToArray());
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}
