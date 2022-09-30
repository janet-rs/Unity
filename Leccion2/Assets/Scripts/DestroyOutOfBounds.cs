using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Clase que permite destruir el objeto comida al momento de salir dels limites.
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: 19-septiembre-2022
*/
public class DestroyOutOfBounds : MonoBehaviour
{
    // Definición de variables
    private float topBound = 30;
    private float lowerBound = -10;
    void Start()
    {

    }


    void Update()
    {
        //Función que delimita el area donde se destruirá la comida y los animales 
        // al salir de la vista del jugador
        if (transform.position.z > topBound)
        {
            //Destruye el objeto al salir de las vita del jugador
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Destruye el objeto y envia un mensaje de qu el juego a terminado
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
