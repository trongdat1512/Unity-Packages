
using System;
using DTD.SOEventSystem;
using UnityEngine;
using UnityEngine.Events;

namespace DTD.SOEventSystem
{
    public abstract class BaseEventListener<T> : MonoBehaviour
    {
        [SerializeField] private BaseEvent<T> eventChannel;
        [SerializeField] private UnityEvent<T> onEventRaised;

        private void OnEnable() => eventChannel.Register(this);

        private void OnDisable() => eventChannel.Unregister(this);

        internal void OnEventRaised(T value) => onEventRaised.Invoke(value);
    }
}