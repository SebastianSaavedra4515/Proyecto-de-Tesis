using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class soles : MonoBehaviour
{
    Rigidbody2D rigi;
    [SerializeField] float velocidad = 2;
    public MiniJuegoSol jugador;
    float PosIncialY;
    // Start is called before the first frame update
    void Start()
    {
        PosIncialY = transform.position.y;
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        // Initiating touch event
        // if touch event takes place
        if (Input.touchCount > 0)
        {
            // get touch position
            Touch touch = Input.GetTouch(0);
            // obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            // get touch to take a deal with
            switch (touch.phase)
            {
                // if you touches the screen
                case TouchPhase.Began:
                    // if you touch the ball
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        jugador.sol++;
                        Destroy(gameObject);
                    }
                    break;

                // you release your finger
                case TouchPhase.Ended:                   
                    break;
            }
        }

        rigi.velocity = Vector2.down * velocidad * Time.deltaTime;
        if(PosIncialY<-6.75)
        {
            jugador.sol--;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
