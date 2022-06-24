using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Juego_Corte : MonoBehaviour
{
    public Text timeText;
    public float Timemax=30;
    float time=0;
    public List<Espacios> puntos;
    float timeRespawn=0;
    public float timeMaxRespawn = 0;
   
    public Image vidaImage;
    [SerializeField] GameObject Worm;
    public float vidaMax = 100;
    public float vida = 0;
    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "" + (int)(Timemax - time);
        timeRespawn += Time.deltaTime;
        vidaImage.fillAmount = vida / vidaMax;

        if (timeRespawn >= timeMaxRespawn)
        {
            bool spawn = false;
            while (spawn == false)
            {
                int num = Random.Range(0, puntos.Capacity);
                if (puntos[num].ocupado == false)
                {
                    Vector3 pos = puntos[num].transform.position;

                    Worm.transform.position = pos;
                    Worm.GetComponent<Gusanos>().posList = num;
                    Instantiate(Worm);
                    puntos[num].ocupado = true;
                    spawn = true;
                }

            }
            timeRespawn = 0;
        }
        if ((int)(Timemax - time) <= 0)
        {
            GetComponent<CambiarScena>().CargarScena("Recompensa2");
        }
        if (vida <= 0)
        {
            GetComponent<CambiarScena>().CargarScena("Prueba1");
        }
    }
}
