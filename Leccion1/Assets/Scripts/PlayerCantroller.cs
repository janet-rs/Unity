using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Descripción: La clase permite que el tanque avance en función a las teclas 
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: septiembre-2022
*/

public class PlayerCantroller : MonoBehaviour
{
    //Declaración de varianles
    public float velocidad = 20;
    void Start()
    {
        
    }
    //Permite que el carro avance en funcion de las teclas, de igual forma permite girar para 
    // evitar y superar los obstaculos 
    void Update()
    {
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up,Time.deltaTime*30*girar);
    }
}
