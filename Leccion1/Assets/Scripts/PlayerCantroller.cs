using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCantroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up,Time.deltaTime*30*girar);
    }
}
