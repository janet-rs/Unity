using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Descripción: Genera animales de forma aleatoria.
    Autor: Brenda Janet Rodríguez Salazar
    Fecha: 23-septiembre-2022
*/
public class SpawnManager : MonoBehaviour
{
    // Definición de variables

    //Arreglo que almacena los prefabs de los animales
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    //Variables para la generación de aninales en automático
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    { 
        //Invoca la funcion personalizada, generando los animales en intervalos de tiempo predefinidos
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval) ;
    }


    void Update()
    {
    
    }

    /*
    Función personalizada que permite generar animales de forma aleatoria
    */
    void SpawnRandomAnimal()
    {
         //Funcion que genera los animales en una posición aleatoria
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
