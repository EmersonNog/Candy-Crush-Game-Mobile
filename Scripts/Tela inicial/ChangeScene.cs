using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public LevelLoader levelLoader;

    public void ChangeS()
    {
        levelLoader.Transition(sceneName);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
