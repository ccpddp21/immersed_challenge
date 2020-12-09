using MLAPI;
using MLAPI.NetworkedVar;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomReporter : MonoBehaviour
{
    [SyncedVar] public int seatsAvailable;

    // Start is called before the first frame update
    void Start()
    {
        seatsAvailable = GameObject.FindGameObjectsWithTag("Student Spawn").Length;
    }
}
