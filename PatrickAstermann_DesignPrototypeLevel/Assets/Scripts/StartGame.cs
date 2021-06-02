using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //VARS
    public static bool gameHasStarted = false;

    public void StartGameNow()
    {
        gameHasStarted = true;
        //Timer();
    }
}
