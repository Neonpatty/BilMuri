using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //VARS
    public Camera fpsCam;
    public float range;    
    public float fireRate;
    public KeyCode sKey;
    public AudioSource gunShot;
    public AudioSource gunCock;
    public AudioSource shotHit;
    public AudioSource missHit;
    public GameObject pHit;
    
    private float nextTimeFire = 0f;

    //REFS
    public PauseMenu pM;
    
    void Update()
    {
        if (pM.gameIsPaused == false)
        {
            if (nextTimeFire <= Time.time)
            {
                if (Input.GetKeyDown(sKey))
                {
                    Shoot();
                    gunShot.Play();
                    gunCock.PlayDelayed(0.5f);
                    nextTimeFire = Time.time + fireRate;
                }
            }
        }            
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);            
            if (hit.transform.gameObject.layer == 9)
            {
                shotHit.Play();
                
                hit.transform.SendMessage("HitByRay");
            }
            else if(hit.transform.gameObject.layer == 10)
            {
                hit.transform.SendMessage("StartGameNow");
            }
            else
            {
                missHit.Play();
            }
            
            GameObject impactGo = Instantiate(pHit, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 2f);
        }
    }
}
