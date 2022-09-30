using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Contrala ls movimientos del avión como el girar o la velocidad 
    con la que avanza el avión
    Autor:Brenda Janet Rodriguez Salazar
    Feha: 26/Septiembre/2022
*/
public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;


    void Start()
    {

    }


    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
