using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlterarCena : MonoBehaviour
{
    public string cena;

    public void Alterar()
    {
        SceneManager.LoadScene(cena);
    }
}
