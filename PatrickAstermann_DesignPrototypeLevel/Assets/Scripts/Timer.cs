using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //VARS
    public float timeRemaining = 30;
    public bool timerRunning = false;
    public Text timerText;

    //REFS
    public EndScreen eS;
    public AnimationPlay aP; 

    public void StartGameNow()
    {
        timerRunning = true;
        aP.PlayAni();
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTimer(timeRemaining);
            }
            else
            {
                Debug.Log("Time Has Run Out");
                timeRemaining = 0;
                timerRunning = false;
                eS.EndGame();
            }
        }
    }

    void DisplayTimer(float timeToDisplay)
    {
        timeToDisplay += 1;

        float mintues = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", mintues, seconds);
    }
}