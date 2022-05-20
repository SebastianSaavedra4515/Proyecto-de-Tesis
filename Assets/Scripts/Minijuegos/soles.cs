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
