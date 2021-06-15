using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    //VARS
    public KeyCode iKey;

    //REFS
    public Shooting s;

    public void Update()
    {
        if (Input.GetKeyDown(iKey))
        {
            ButtonPushed();
        }
    }

    public void ButtonPushed()
    {
        if(s.hit.transform.gameObject.layer == 10)
        {
            SendMessage("StartGameNow");
        }
    }
}