using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //VARS
    public Camera fpsCam;
    public float range;
    public KeyCode sKey;

    void Update()
    {
        if (Input.GetKeyDown(sKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            if (hit.transform.gameObject.layer == 9)
            {
                hit.transform.SendMessage("HitByRay");
            }
            if(hit.transform.gameObject.layer == 10)
            {
                hit.transform.SendMessage("StartGameNow");
            }
            Debug.Log(hit.transform.name);
        }
    }
}
