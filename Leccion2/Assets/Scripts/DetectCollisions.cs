using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Clase que permite destruir los objetos al momento de tocarse entrese si
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: 29-septiembre-2022
*/
public class DetectCollisions : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }
    //Función que permite destruir los objetos
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
