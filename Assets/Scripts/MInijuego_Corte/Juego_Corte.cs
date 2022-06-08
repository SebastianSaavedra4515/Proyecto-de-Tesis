using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juego_Corte : MonoBehaviour
{
    public Text timeText;
    public float Timemax=30;
    float time=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "" +(int)(Timemax-time);
        //if()
    }
}
