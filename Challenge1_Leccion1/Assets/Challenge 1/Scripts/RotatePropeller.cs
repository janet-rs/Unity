using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Descripción: Permite que la hélice del avión gire al momento de iniciar el juego
    Autor:Brenda Janet Rodriguez Salazar
    Feha:26/Septiembre/2022
*/
public class RotatePropeller : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       transform.Rotate(Vector3.forward,40); 
    }
}
