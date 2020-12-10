using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseHand : NetworkedBehaviour
{
    [SerializeField] private AppEvent _handRaisedEvent;
    private UserData _userData;
    // Start is called before the first frame update
    void Start()
    {
        if (_userData == null)
        {
            _userData = Resources.Load("ScriptableObjects/User Data") as UserData;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            // SimulateHandRaise();
        }
    }

    private void Engage()
    {
        _handRaisedEvent.Raise();
        // _userData.ActiveChair.gameObject.GetComponentInChildren<ChairIndicator>().ChangeColorToWaiting();
    }


}
