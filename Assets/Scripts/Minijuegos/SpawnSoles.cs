using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSoles : MonoBehaviour
{
    public MiniJuegoSol jugador;
    public float tiempoMax=1;
    public float time;
    public GameObject Soles;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time>=tiempoMax)
        {
            Soles.transform.position = new Vector3(Random.Range(-12f,12f), transform.position.y, 0);
            Soles.GetComponent<soles>().jugador = this.jugador;
            Instantiate(Soles);
            time = 0;
        }
    }
}
