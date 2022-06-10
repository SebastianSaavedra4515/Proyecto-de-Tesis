using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espacios : MonoBehaviour
{
    public bool ocupado=false;
    [SerializeField] Juego_Corte vida;
    float time = 0;
    public float TiempoDano=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ocupado == true)
        {
            time += Time.deltaTime;
            if (time >= TiempoDano)
            {
                vida.vida-=3;
                time = 0;
            }

            
        }
        else
        {
            time = 0;
        }
    }
}
