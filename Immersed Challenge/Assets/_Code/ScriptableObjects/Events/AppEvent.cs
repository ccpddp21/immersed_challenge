using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "App Event")]
public class AppEvent : ScriptableObject
{
    private List<AppEventListener> listeners = new List<AppEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(AppEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(AppEventListener listener)
    {
        listeners.Remove(listener);
    }
}
