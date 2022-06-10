using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinsa : MonoBehaviour
{

    float deltaX, deltaY;

    Rigidbody2D rb;

    bool moveAllowed = false;
    public Transform Punto;
    public bool vacio = true;
    public Juego_Corte juego;
    Vector3 posInicial;
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();
        posInicial = transform.position;


    }

    void Update()
    {


        
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);


            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {


              
                case TouchPhase.Began:


                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {


                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;


                   
                        moveAllowed = true;


                      
                        rb.freezeRotation = true;
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 0;
                     
                    }
                    break;


              
                case TouchPhase.Moved:
                    
                   
                        rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    break;


                // you release your finger
                case TouchPhase.Ended:
                    moveAllowed = false;


                    transform.position = posInicial;
                    break;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="gusanos"&&vacio==true)
        {
           
            Debug.Log("Entro");
            collision.GetComponent<Gusanos>().pincho=this ;
            collision.GetComponent<Gusanos>().pinchado = true;
            Debug.Log(collision.GetComponent<Gusanos>().posList);
            juego.puntos[collision.GetComponent<Gusanos>().posList].ocupado = false;
            vacio = false;
        }
        Debug.Log(collision.tag);
        Debug.Log(vacio);
    }
}