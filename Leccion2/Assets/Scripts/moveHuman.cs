using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHuman : MonoBehaviour
{
    // Start is called before the first frame update
    public float vel = 0.5F;
    public float maximo=18;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >maximo)
        {
            transform.position=new Vector3(maximo,transform.position.y, transform.position.z);
        }

        if (transform.position.x <-maximo)
        {
            transform.position=new Vector3(-maximo,transform.position.y, transform.position.z);
        }
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
    }
}
