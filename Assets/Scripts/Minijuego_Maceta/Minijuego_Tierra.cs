using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Minijuego_Tierra : MonoBehaviour
{
    public float TierraVictoria = 10;
    public float tierra = 0;
    public Image vidaImage;
    public bool findeljuego = false;
    public float speed=7;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        vidaImage.fillAmount = tierra / TierraVictoria;
        Debug.Log(tierra / TierraVictoria);
        Vector3 tilt = Input.acceleration;
        CondicionVictoria();
        tilt = Quaternion.Euler(90, 0, 0) * tilt;
        if (tierra < 0)
        {
            tierra = 0;
        }
        if (tierra >=TierraVictoria)
        {
            tierra = TierraVictoria;
        }

        if (tilt.x >= 0.2 && transform.position.x >= -7.02)
        {
            transform.Translate(Vector3.right *speed* Time.deltaTime);
        }
        else
        {
            if (tilt.x <= -0.2 && transform.rotation.z <= 10.36)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    public void SubirTierra()
    {
        tierra++;
    }
    public void BajarTierra()
    {
        tierra--;
    }
    void CondicionVictoria()
    {
        if (tierra >= TierraVictoria)
        {
            findeljuego = true;
            GetComponent<CambiarScena>().CargarScena("Prueba1");
        }
    }
}
