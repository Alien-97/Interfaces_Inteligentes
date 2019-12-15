using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour {
    // La secuencia es la siguiente:
    // El Jugador colisiona con un objeto, ese objeto tiene un Ontrigger activado, en ese trigger se llama a un metodo del gamecontroller, al metodo AumentarPoder por ejemplo
    // Ese metodo que está en gamecontroller, llamada al evento, los eventos son de tipo delegado en C#, es decir, están a la escucha y son punteros a funciones, resultado que ese puntero, en la clase PlayerPower está apuntando al método Aumento
    // Poder, que se encarga de aumentar el poder, y hace todo lo que se estime oportuno.
    // El evento es un intermediario entre el método y el puntero
    public int poder = 0;
    private int energia;

    private Transform tf;
    // Use this for initialization
    void Start () {
        //GameController.AumentoPoder += AumentarPoder; // Vinculas al evento(al puntero) y al método, el evento es un vector de funciones porque lo único que hace es llamar funciones
        //GameController.ReduccionPoder += ReducirPoder;
        GameController.Atacar +=AtacarDeformarYAumentarEnergia;
        energia = 1;
    }


    /*private void AumentarPoder()
    {
        poder++;
        Debug.Log(poder);
    }*/

    public int Energia(){
        return energia;
    }

    /*private void ReducirPoder()
    {
        poder--;
        Debug.Log(poder);
    }*/

    private void AtacarDeformarYAumentarEnergia(int energia){

        Debug.Log(poder);
        // Disminuye mi poder
        poder -= energia;
        // Disminuye mi tamaño
        float newScale = tf.localScale.x - (energia * 0.3f);
        if (newScale >= 0) {
            tf.localScale = new Vector3 (newScale, newScale, newScale);
            tf.localPosition = new Vector3 (tf.localPosition.x, newScale / 2, tf.localPosition.z);
        }

        Debug.Log ("Atacado ObjA " + tf.localScale.ToString());
    }

    // Update is called once per frame
    void Update () {
		
	}
}
