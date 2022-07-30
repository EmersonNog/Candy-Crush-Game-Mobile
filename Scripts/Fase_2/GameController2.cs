using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour
{
    public GameObject OverPanel;
    public GameObject hotbar;
    public GameObject back;
    public string sceneName;
    public LevelLoader levelLoader;

    public void GameOver()
    {
        OverPanel.SetActive(true);
        hotbar.SetActive(false);
        back.SetActive(false);
    }

    public void Reload()
    {
        levelLoader.Transition(sceneName);
    }

    public void quit()
    {
        levelLoader.Transition(sceneName);
    }
}
