using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //VARS
    public int pValue = 0; //intial point value
    public int respawnT;

    //REFS
    public GivePoints gP; //reference to give points script
    public Shooting sH; //reference to shooting script

    //will send hit targets value to the awardpoints function
    public void HitByRay()
    {
        gP.AwardPoints(pValue);
        //DestoryAndRespawn();
    }

    //public void DestoryAndRespawn()
    //{
    //    if(sH.hit.transform.gameObject.layer == 9)
    //    {
    //        gameObject.SetActive(false);
    //        StartCoroutine(Wait());
    //        gameObject.SetActive(true);
    //    }
    //}

    //IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(5);
    //}
}