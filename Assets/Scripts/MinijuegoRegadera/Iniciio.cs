using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciio : MonoBehaviour
{
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
        //Debug.Log(collision.tag);
        if(collision.tag=="conexion")
        {
            collision.transform.parent.GetComponent<Camino>().casilla.conectado = true;
        }
    }
}
