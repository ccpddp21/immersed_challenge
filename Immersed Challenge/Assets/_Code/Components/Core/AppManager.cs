using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager Singleton;

    void Awake()
    {
        Singleton = this;
    }
}
