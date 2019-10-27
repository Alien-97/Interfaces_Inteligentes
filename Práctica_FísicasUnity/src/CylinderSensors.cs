using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSensors : MonoBehaviour
{
    // Start is called before the first frame update
	public Renderer objectRenderer; 
    public Rigidbody rb;
    public float tiempoFisico = 0;
    public float tiempoCambioColor = 2;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision other) // ¿tiene que ser privado este método?
    {

        if(other.gameObject.CompareTag("Jugador")){ 
            objectRenderer.material.color = new Color(1,0,0,1);
        }
        else if(other.gameObject.CompareTag("Esfera1")){
        	objectRenderer.material.color = new Color(0,0,1,1);
        }
        else if(other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("Capsule")){
            
            objectRenderer.material.color = new Color(0,1,0);
            
        }
        tiempoFisico = Time.time;
    }

    void OnCollisionStay(Collision other){
    	if(other.gameObject.CompareTag("Jugador")){ 
    		if( Time.time - tiempoFisico > tiempoCambioColor){
            	objectRenderer.material.color = new Color(1,0.25f,0.25f,1);
        	}
        }
        else if(other.gameObject.CompareTag("Esfera1")){
        	if(Time.time - tiempoFisico > tiempoCambioColor){
        		objectRenderer.material.color = new Color(0.25f,0.25f,1,1);
        	}
        }
        else if(other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("Capsule")){
            if(Time.time - tiempoFisico > tiempoCambioColor){
                objectRenderer.material.color = new Color(0.25f,1,0.25f);
            }
        }
        
    }

    void OnCollisionExit(Collision other){
    	if(other.gameObject.CompareTag("Jugador")){ 

            objectRenderer.material.color = new Color(1,0.50f,0.50f,1);
        }
        else if(other.gameObject.CompareTag("Esfera1")){
        	objectRenderer.material.color = new Color(0.50f,0.50f,1,1);
        }
        else if(other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("Capsule")){
            objectRenderer.material.color = new Color(0.50f,1,0.50f);  
        }
    }
    
}
