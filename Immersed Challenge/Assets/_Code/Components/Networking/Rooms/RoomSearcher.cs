using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RoomSearcher : MonoBehaviour
{
    [SerializeField] private UserData _userData;

    void Awake()
    {
        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data") as UserData;
        }
    }

    void Start()
    {
        StartCoroutine(FindAllPublicRooms());
    }

    /// Retrive data for list of all active [public] Rooms
    public IEnumerator FindAllPublicRooms()
    {
        // Send HTTP request to Rooms API
        UnityWebRequest request = UnityWebRequest.Get(string.Format("http://localhost:3000/rooms/public"));
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();

        try
        {
            Room.RoomCollection rooms = JsonUtility.FromJson<Room.RoomCollection>(request.downloadHandler.text);
            Debug.Log(rooms.rooms.Length);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    /// Retrive data for all Rooms the User is associated 
    public IEnumerator GetRegisteredRooms()
    {
        // Send HTTP request to Rooms API
        UnityWebRequest request = UnityWebRequest.Get(string.Format("http://localhost:3000/rooms/public?roomIds={0}", _userData.RegisterRooms.ToArray().ToString()));
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();
    }
}
