using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Casilla : MonoBehaviour
{
    // Start is called before the first frame update
   
    public int caminoCorrecto=0;
    public int caminocolocada=-1;
    public bool Win = false;
    [SerializeField] List<Camino> caminos=new List<Camino>();
    [SerializeField] List<Toggle> ToglesCaminos = new List<Toggle>();
    public bool vacio = true;
    [SerializeField] Minijuegoregadera jugador;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if()
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
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)&&vacio==true)
                    {
                        for(int i=0;i<ToglesCaminos.Capacity;i++)
                        {
                            if(ToglesCaminos[i].isOn==true&&ToglesCaminos[i].GetComponent<BotonesCaminos>().numeroUSos>0)
                            {
                                caminocolocada= ToglesCaminos[i].GetComponent<BotonesCaminos>().identificador;
                                vacio = false;
                                ToglesCaminos[i].GetComponent<BotonesCaminos>().numeroUSos--;
                                ToglesCaminos[i].isOn =false;
                                i = ToglesCaminos.Capacity + 1;
                            }
                        }
                    }
                    break;

                // you release your finger
                case TouchPhase.Ended:
                    break;
            }
        }
        if (caminocolocada!=-1)
        {

            caminos[caminocolocada ].gameObject.SetActive(true);
        }
       
        Comprobar();
    }
    public void Comprobar()
    {
        if (caminocolocada == caminoCorrecto && Win == false) 
        {
            jugador.caminosCorrectos++;
            Win = true;
        }
    }

}
