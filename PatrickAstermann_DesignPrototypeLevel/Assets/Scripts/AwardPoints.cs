using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AwardPoints : MonoBehaviour
{
    //VARS
    public int pValue;
    public int score = 0;
    public Text points;

    public void HitByRay()
    {
        score += pValue;
        points.text = score.ToString();
        Debug.Log("i have been hit");
    }
}