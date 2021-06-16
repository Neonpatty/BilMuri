using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //VARS
    public int pValue = 0; //intial point value

    //REFS
    public GivePoints gP; //reference to give points script

    //will send hit targets value to the awardpoints function
    public void HitByRay()
    {
        gP.AwardPoints(pValue);
    }
}