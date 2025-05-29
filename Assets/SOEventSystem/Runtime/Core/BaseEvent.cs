using System.Collections.Generic;
using UnityEngine;

namespace DTD.SOEventSystem
{
    public abstract class BaseEvent<T> : ScriptableObject
    {
        private readonly List<BaseEventListener<T>> _listeners = new();

        internal void Register(BaseEventListener<T> listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);
        }

        internal void Unregister(BaseEventListener<T> listener) => _listeners.Remove(listener);

        public void RaiseEvent(T value)
        {
            foreach (var listener in _listeners)
                listener.OnEventRaised(value);
        }
    }
}