ausing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public int counter = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 4;
    }

    void FixedUpdate(){

        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(new Vector3(1,0,0)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(new Vector3(-1,0,0)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(new Vector3(0,0,1)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(new Vector3(0,0,-1)*speed, ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision other) 
    {
        if(other.gameObject.tag == "Esfera1"){ 

            counter = counter +1;
        }
    }
}
