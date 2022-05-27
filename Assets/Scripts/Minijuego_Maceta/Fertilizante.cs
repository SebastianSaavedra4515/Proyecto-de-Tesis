using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fertilizante : MonoBehaviour
{
    public Minijuego_Tierra jugador;
    public bool es;//true=fertilzante fales = gusano
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=-9)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"&&es==true)
        {
            jugador.SubirTierra();
            Destroy(gameObject);
        }
        if (collision.tag == "Player" && es == false)
        {
            jugador.BajarTierra();
            Destroy(gameObject);
        }

    }

}
