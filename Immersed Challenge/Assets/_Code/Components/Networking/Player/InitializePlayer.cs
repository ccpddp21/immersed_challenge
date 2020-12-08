using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayer : NetworkedBehaviour
{
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
        if (!IsLocalPlayer)
        {
            Destroy(transform.GetComponentInChildren<Camera>().gameObject);
        }

        MoveToSpawnPoint();
    }

    private void MoveToSpawnPoint()
    {
        if (_userData.UserType == UserTypes.Professor)
        {
            this.transform.position = GameObject.FindGameObjectWithTag("Professor Spawn").transform.position;
        }
    }
}
