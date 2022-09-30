/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para controlar el movimiento del avión
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        // mover el avión hacia adelante 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // inclinar el avión según las teclas de flecha arriba y abajo
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
