using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Dar movimiento a la comida
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: 23-septiembre-2022
*/
public class MoveForward : MonoBehaviour
{
    // Definición de variables
    public float velocidad = 40.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        // Función que permite el mocimiento de la comida
        transform.Translate(Vector3.forward*Time.deltaTime * velocidad);
    }
}
