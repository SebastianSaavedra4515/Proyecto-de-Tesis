using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Minijuegoregadera : MonoBehaviour
{
    [SerializeField] List<Casilla> caminos = new List<Casilla>();
    public int caminosCorrectosNecesario;
    public int caminosCorrectos;
    [SerializeField] List<Toggle> ToglesCaminos = new List<Toggle>();
    public Text a;
    public bool finJuego=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.text = "" + caminosCorrectos;

        if (finJuego==true)
        {
            SceneManager.LoadScene("Recompensa1");
        }
    }

    public void ControlTogle1()
    {
        ToglesCaminos[1].isOn = false;
        ToglesCaminos[2].isOn = false;
        ToglesCaminos[3].isOn = false;
        ToglesCaminos[4].isOn = false;
        ToglesCaminos[5].isOn = false;
    }
    public void ControlTogle2()
    {
        ToglesCaminos[0].isOn = false;
        ToglesCaminos[2].isOn = false;
        ToglesCaminos[3].isOn = false;
        ToglesCaminos[4].isOn = false;
        ToglesCaminos[5].isOn = false;
    }
    public void ControlTogle3()
    {
        ToglesCaminos[0].isOn = false;
        ToglesCaminos[1].isOn = false;
        ToglesCaminos[3].isOn = false;
        ToglesCaminos[4].isOn = false;
        ToglesCaminos[5].isOn = false;
    }
    public void ControlTogle4()
    {
        ToglesCaminos[0].isOn = false;
        ToglesCaminos[1].isOn = false;
        ToglesCaminos[2].isOn = false;
        ToglesCaminos[4].isOn = false;
        ToglesCaminos[5].isOn = false;
    }
    public void ControlTogle5()
    {
        ToglesCaminos[0].isOn = false;
        ToglesCaminos[1].isOn = false;
        ToglesCaminos[2].isOn = false;
        ToglesCaminos[3].isOn = false;
        ToglesCaminos[5].isOn = false;
    }
    public void ControlTogle6()
    {
        ToglesCaminos[0].isOn = false;
        ToglesCaminos[1].isOn = false;
        ToglesCaminos[2].isOn = false;
        ToglesCaminos[3].isOn = false;
        ToglesCaminos[4].isOn = false;
    }
}
