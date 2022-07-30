using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timing : MonoBehaviour
{

    public float timeStart = 120;
    public Text textBox;


    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }
}
