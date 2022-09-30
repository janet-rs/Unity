using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Permite controllar el jugador, en esta clase se da movimiento al jugador y delimita el área que 
    puede recorrer el jugador.
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: 19-septiembre-2022
*/

public class PlayerControlller : MonoBehaviour
{
    /*Se definen las variables, donde la primera permite definir la orientación en las que el jugador se mueve,
     la variable "velocidad" define la velocidad con la que el jugador se moverá, y por último "maximo" que limita 
     el espacio que puede recorrer el jugador
     */
    public float horizontalInput;
    public float velocidad = 10.0f;
    public float maximo = 15;

    //Variable de referecia al objeto food
    public GameObject pizzaPrefab;
    void Start()
    {

    }

    void Update()
    {
        /*
            Función que delimita el espacio en el que el jugador puede moverse
        */
        if (transform.position.x < -maximo)
        {
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }

        if (transform.position.x > maximo)
        {
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }
        // Orientación en la que el jugador se desplaza
        horizontalInput = Input.GetAxis("Horizontal");

        //Permite que el jugador se mueva
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * velocidad);

        //Función que permite lanzar la comida como proyectil presionando una 
        //tecla en especifico
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(pizzaPrefab, transform.position,pizzaPrefab.transform.rotation);
            
        }
    }
}
