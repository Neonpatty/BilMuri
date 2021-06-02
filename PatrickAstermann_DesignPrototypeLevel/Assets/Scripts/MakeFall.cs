using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MakeFall : MonoBehaviour
{
    //VARS
    public int mSenderId;
    public GameObject anim;

    void Start()
    {
        EventManager.m_instance.onFalling.AddListener(Falling);
    }

    public void Falling(int sender)
    {
        if (mSenderId == sender)
        {
            anim.GetComponent<Animation>().Play();
        }

    }
}
