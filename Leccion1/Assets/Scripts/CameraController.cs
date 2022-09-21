using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject tanque;
    // Start is called before the first frame update

    private Vector3 pos= new Vector3(0,5,-5);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =tanque.transform.position + pos;
    }
}
