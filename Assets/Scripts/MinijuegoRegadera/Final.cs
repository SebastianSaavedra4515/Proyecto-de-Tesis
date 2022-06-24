
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public Minijuegoregadera juego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "conexion")
        {
            if (collision.transform.parent.GetComponent<Camino>().casilla.conectado == true)
            {
                Debug.Log("fin");
                juego.finJuego = true;
            }
        }
    }
}
