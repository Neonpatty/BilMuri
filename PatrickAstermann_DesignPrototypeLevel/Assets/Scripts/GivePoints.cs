using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GivePoints : MonoBehaviour
{
    //VARS
    public int score = 0;
    public Text points;
    public Timer tR;

    public void AwardPoints(int pValue)
    {
        if(tR.timerRunning == true)
        {
            score += pValue;
            points.text = score.ToString();
            Debug.Log("i have been hit");
        }
    }
}