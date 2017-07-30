using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro2 : MonoBehaviour {

    public float velocidad = 0.1f;

    Vector3 posicionInicial;


    public MoverCarro BotonAzul;


    // Use this for initialization
    void Start()
    {


    }
    public void Reset()
    {
        transform.position = posicionInicial;
    }
    // Update is called once per frame
    void Update()
    {
        float direccion;
        direccion = 0;
        if (BotonAzul.pulsado)
        {
            direccion = 4;
            BotonAzul.pulsado = false;

        }
        else
        {
            direccion = 0;

        }

        float posY = transform.position.y + (direccion * velocidad * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(posY, -8, 8));
        transform.position = new Vector3(transform.position.x, transform.position.y);







        if (posY >= 4.196839)
        {
            print("Has ganado azul");

        }
        else
        {

            print(posY);
        }

    }




}
