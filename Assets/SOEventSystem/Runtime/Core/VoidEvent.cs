
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Void Event", menuName = "Events/Void Event")]
public class VoidEvent : ScriptableObject
{
    private readonly List<VoidEventListener> _listeners = new();

    internal void Register(VoidEventListener listener)
    {
        if (!_listeners.Contains(listener))
            _listeners.Add(listener);
    }

    internal void Unregister(VoidEventListener listener) => _listeners.Remove(listener);

    public void RaiseEvent()
    {
        foreach (var listener in _listeners)
            listener.OnEventRaised();
    }
}