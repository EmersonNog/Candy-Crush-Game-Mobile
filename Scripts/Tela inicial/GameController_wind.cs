using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController_wind : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject PanelMenuMain;

    public void Opcoes()
    {
        optionsPanel.SetActive(true);
        PanelMenuMain.SetActive(false);
    }

    public void back()
    { 
        PanelMenuMain.SetActive(true);
        optionsPanel.SetActive(false);
    }
}
