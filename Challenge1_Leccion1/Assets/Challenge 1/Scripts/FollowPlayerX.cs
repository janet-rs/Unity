using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción:
    Autor:Brenda Janet Rodriguez Salazar
    Feha:
*/
public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - plane.transform.position;
    }
    void Update()
    {
        transform.position = plane.transform.position + offset;

    }
}
