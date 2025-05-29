
using UnityEngine;
using UnityEngine.Events;

public class VoidEventListener : MonoBehaviour
{
    [SerializeField] private VoidEvent eventChannel;
    [SerializeField] private UnityEvent onEventRaised;
    
    private void OnEnable() => eventChannel.Register(this);

    private void OnDisable() => eventChannel.Unregister(this);

    internal void OnEventRaised() => onEventRaised.Invoke();
}