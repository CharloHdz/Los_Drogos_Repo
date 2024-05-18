using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Roca : MonoBehaviour
{
    //entera
    public int monedas = 0;

    //flotante
    public float vida = 100.1f;
    public float velocidad = 0.5f;

    //booleana
    public bool EnSuelo = true;

    //string
    public string nombre = "Roca";


    //Rigidbody2D
    public Rigidbody2D rb;

    //Text
    public TextMeshProUGUI Label;

    void Start()
    {
        print("juego iniciado");
    }

    void Update()
    {
        //movimiento del personaje
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * velocidad, rb.velocity.y);
        }

        if(Input.GetAxis("Vertical") != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxis("Vertical") * velocidad);
        }   

        Label.text = nombre;
    }
}
