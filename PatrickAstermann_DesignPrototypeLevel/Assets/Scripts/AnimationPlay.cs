using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationPlay : MonoBehaviour
{
    //VARS
    public Animator rail1;
    public Animator rail2;
    public Animator cog1;
    public Animator cog2;
    public Animator udr1;
    public Animator udr2;
    public Animator sSign;

    //REFS
    public Timer tR;

    public void PlayAni()
    {
        if(tR.timerRunning == true)
        {
            rail1.enabled = true;
            rail2.enabled = true;
            cog1.enabled = true;
            cog2.enabled = true;
            udr1.enabled = true;
            udr2.enabled = true;
            sSign.enabled = true;
        }
    }
}