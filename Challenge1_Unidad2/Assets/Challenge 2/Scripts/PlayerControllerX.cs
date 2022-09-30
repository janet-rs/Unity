using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float esp = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& esp <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            esp =1;
        
        }
        if(esp>=0){
           esp-=Time.deltaTime; 
        }
        
    }
}
