using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public int VIDA = 0;
    public int TempoDeReposicao;
    private bool Contar;
    public GameController2 fimDeJogo2;
    public GameObject OverPanel;

    void Start()
    {
        VIDA += 1;
        Contar = true;
    }

    void Update()
    {
        if (Contar == true)
        {
            StartCoroutine("Vida");
            Contar = false;
        }

    }
    IEnumerator Vida()
    {
        yield return new WaitForSeconds(TempoDeReposicao);
        Contar = true;
        VIDA += 1;

        if (VIDA == 20)
        {
            Debug.Log("GameOVER!");
            fimDeJogo2.GameOver();
        }
    }

}