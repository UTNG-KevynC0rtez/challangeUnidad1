/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para el funcionamiento de la elice
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliceController : MonoBehaviour
{
    //Se declara el atributo para la velocidad con la que va girar la elice
    public float velocidad = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se configura la velocidad de la elice
        transform.Rotate(Vector3.forward * velocidad);
    }
}
