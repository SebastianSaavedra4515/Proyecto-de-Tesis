using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprobar : MonoBehaviour
{
    public Camino cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInParent<Camino>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag=="conexion")
        {
            if (collision.GetComponent<Comprobar>().cam.casilla.conectado == true )
            {
                Debug.Log("a");
                cam.casilla.conectado =true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        Debug.Log(collision.tag);
    }
}
