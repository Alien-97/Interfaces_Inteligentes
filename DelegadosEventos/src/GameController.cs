using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	//La forma de comunicar el puntero a un metodo (el delegado) y dicho metodo es el evento, un evento que comunica un cambio de luz, otro que está a la escucha del metodo cuando se choca con el objeto A 
	// cuando se choca con un objeto de tipo A
    public delegate void PlayerEvents(); // El tipo delegado para declarar los eventos
    public static event PlayerEvents CambioLuz;
    //public static event PlayerEvents AumentoPoder;
    //public static event PlayerEvents ReduccionPoder;
    public static event PlayerEvents Atacar;
    private PlayerPower jugador;

    void Update()
    {   
    	if (Input.GetKeyDown(KeyCode.L)) //Si se pulsa la tecla L, la luz, que se active o no, depende de que se pulse una tecla, el encender luz lo metemos en el update porque
        // no hay una función para gestionar cuando se pulsa una tecla, como lo hay para colisión. Frame por frame, estamos atentos a que se pulse alguna tecla, pero no estamos atentos
        // a colisiones, 
        {
            CambioLuz(); // Está llamando al evento del mismo nombre arriba, digamos que los eventos son métodos
            Debug.Log("pulsada tecla ");
        }

        GameObject Ethan = GameObject.Find ("ThirdPersonController");
        jugador = Ethan.GetComponent<PlayerPower> ();
        
        if (Input.GetKeyDown(KeyCode.X))
            Atacar(jugador.Energia());

            /*if (Input.GetKeyDown(KeyCode.Z))
                Saquear();*/
                
    }

    public static void AumentarPoder() //Depende de una colision
    {
        if (AumentoPoder != null)
        {
            AumentoPoder();
        }
    }

    public static void ReducirPoder() //Depende de una colision
    {
        if (ReduccionPoder != null)
        {
            ReduccionPoder();
        }
    }

    /*public static void AtacarObjetoA(){
        if(  Atacar!=null){
            Atacar();
        }
    }*/


}
