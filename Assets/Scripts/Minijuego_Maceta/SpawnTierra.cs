using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTierra : MonoBehaviour
{
    public Minijuego_Tierra jugador;
    public float tiempoMax = 2.5f;
    public float time;
    public GameObject Tierra;
    public GameObject Gusanos;
    bool es=true;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= tiempoMax)
        {
           
            if(es==true)
            {
                Tierra.transform.position = new Vector3(Random.Range(-7.02f, 10.36f), transform.position.y, 0);
                Tierra.GetComponent<Fertilizante>().jugador = this.jugador;
                Instantiate(Tierra);
                es = false;
            }
            else
            {
                Gusanos.transform.position = new Vector3(Random.Range(-7.02f, 10.36f), transform.position.y, 0);
                Gusanos.GetComponent<Fertilizante>().jugador = this.jugador;

                Instantiate(Gusanos);
                es = true;
            }
          
            time = 0;
        }
    }
}
