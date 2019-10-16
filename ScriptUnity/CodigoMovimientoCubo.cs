using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Moverse delante, atras, izquierda, derecha
public class MovimientoCubo : MonoBehaviour
{
	
	// El frame es como la unidad de tiempo en cualquier tipo de animación
	public float speed; // La velocidad a la que se hace el movimiento
	private Transform tf; // operaremos a nivel no físico, por eso creamos el Transform
    // Start is called before the first frame update
    void Start() // el Start es como un constructor, es lo primero que se hace al ejecutar el juego, define posicion jugadores
    {
        speed = 0.0f;  // 
        tf = GetComponent<Transform>(); //Inicializamos el objeto, un componente

    }

    // Update is called once per frame, el update se ejecuta continuamente, de hecho es un bucle, véase
    // https://docs.unity3d.com/Manual/ExecutionOrder.html la velocidad es constante
 

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // a derecha o izquieda
        float moveVertical = Input.GetAxis("Vertical"); // delante o atrás , El movimiento en vertical, en el eje z, eso representa el eje z
		// GetAxis devuelve el valor del eje virtual identificado por axisName, que es el string que le pasas, lo que hace es devolverte un número 
		

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical); // usas el vector3 porque necesitas saber cuánto se va a mover en el eje x, cuánto en el eje y, y cuánto en el z.

		tf.Translate(movement * Time.deltaTime * speed); // Usamos deltaTime, el tiempo transcurrido, y no por frame,  para usar tiempo real, y no tiempo físico,porque tendríamos que calcular colisiones, para que esta velocidad sea definida en base a distancia por tiempo, y no distancia por frame
    }
}
