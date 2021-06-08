using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //VARS
    public int pValue = 0;

    //REFS
    public GivePoints gP;

    public void HitByRay()
    {
        gP.AwardPoints(pValue);
    }
}