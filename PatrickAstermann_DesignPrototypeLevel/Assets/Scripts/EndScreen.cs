using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    //VARS
    public GameObject endGameUi;
    public GameObject mainGui;
    public GameObject fpsDot;
    public Text playerScore;

    //REFS
    public GivePoints gP;

    public void EndGame()
    {
        endGameUi.SetActive(true);
        mainGui.SetActive(false);
        fpsDot.SetActive(false);
        DisplayScore();
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void DisplayScore()
    {
        playerScore.text = (gP.score.ToString());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("ShootingGallery");
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
