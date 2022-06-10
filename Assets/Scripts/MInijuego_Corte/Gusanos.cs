using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gusanos : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pinchado = false;
    public Pinsa pincho;
    public int posList=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pinchado==true)
        {
            transform.position = pincho.Punto.position;
        }
        else
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "basurero")
        {
            pincho.vacio = true;
           
            Destroy(gameObject);
        }
    }
}
