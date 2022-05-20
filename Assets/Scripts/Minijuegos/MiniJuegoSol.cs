using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniJuegoSol : MonoBehaviour
{
    public int solNecesario = 10;
    public int sol = 0;
    public Image vidaImage;
    public bool findeljuego = false;
    Vector2 touchIncial;
    Vector2 touchFinal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaImage.fillAmount = sol / solNecesario;
        if (sol<0)
        {
            sol = 0;
        }
        if(sol>=solNecesario)
        {
            sol = solNecesario;
        }
        CondicionVictoria();
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchIncial = Input.GetTouch(0).position;
            
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            touchFinal = Input.GetTouch(0).position;
           

        }
    } 
    void CondicionVictoria()
    {
        if (sol >= solNecesario)
        {
            findeljuego = true;
        }
    }
}
