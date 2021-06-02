using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class MyEvent : UnityEvent<int> { }

public class EventManager : MonoBehaviour
{
    public static EventManager m_instance;

    // Awake is called when game is played
    void Awake()
    {
        m_instance = this;
    }

    // EVENT LIST

    public MyEvent onAwardPoints, onFalling;
    public void AwardPoints(int sender)
    {
        onAwardPoints?.Invoke(sender);
    }

    public void HasFallen(int sender)
    {
        onFalling?.Invoke(sender);
    }
}
