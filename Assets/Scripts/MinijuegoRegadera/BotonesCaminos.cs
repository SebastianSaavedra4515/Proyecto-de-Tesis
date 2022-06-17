using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BotonesCaminos : MonoBehaviour
{
    public int identificador;
    public int numeroUSos;
    public Text Cantidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cantidad.text = numeroUSos + "X";
        if(numeroUSos<=0)
        {
            numeroUSos = 0;
        }
    }
}
