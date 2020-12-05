using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayer : NetworkedBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!IsLocalPlayer)
        {
            Destroy(transform.GetComponentInChildren<Camera>().gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
