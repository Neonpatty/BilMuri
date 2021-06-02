using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GivePoints : MonoBehaviour
{
    //VARS
    public int mSender;
    public int pValue;
    public int score = 0;
    public Text points;

    private void Start()
    {
        EventManager.m_instance.onAwardPoints.AddListener(AwardPoints);
    }

    public void AwardPoints(int sender)
    {
        if (mSender == sender)
        {
            score += pValue;
            points.text = score.ToString();
            Debug.Log("i have been hit");
        }

    }
}