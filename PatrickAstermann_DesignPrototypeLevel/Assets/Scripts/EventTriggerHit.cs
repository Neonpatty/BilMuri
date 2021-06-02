using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTriggerHit : MonoBehaviour
{
    public MyEvent mOnTriggerHit;

    public void HitByRay()
    {
        mOnTriggerHit.Invoke(0);
    }
}
