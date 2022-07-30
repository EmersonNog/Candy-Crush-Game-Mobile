using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_pause_home : MonoBehaviour
{
    bool isPaused = true;
    public string nomeDaCena;

    public void playGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
    public void homeGame()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
