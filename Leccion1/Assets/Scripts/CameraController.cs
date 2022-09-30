using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Clase que permite que la camara siga el tanque del jugador
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: septiembre-2022
*/

public class CameraController : MonoBehaviour
{
    public GameObject tanque;
    
    //Posiciona la camara en un lugar espacifico
    private Vector3 pos= new Vector3(0,5,-5);
    void Start()
    {
        
    }

 //Actualiza la posicon de la camara en funcion a ala posicion del tanque 
    void Update()
    {
        transform.position =tanque.transform.position + pos;
    }
}
