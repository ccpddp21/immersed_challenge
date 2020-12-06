using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
