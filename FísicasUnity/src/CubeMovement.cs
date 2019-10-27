using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public int CubeCounter = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 4;
    }

    void FixedUpdate(){

        if(Input.GetKey(KeyCode.I)){
            rb.AddForce(new Vector3(1,0,0)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.M)){
            rb.AddForce(new Vector3(-1,0,0)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.L)){
            rb.AddForce(new Vector3(0,0,1)*speed, ForceMode.Acceleration);
        }

        if(Input.GetKey(KeyCode.J)){
            rb.AddForce(new Vector3(0,0,-1)*speed, ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision other)  // Count collisions from player tagged as "Jugador" or spheres tagged as "Esfera1"
    {
        if(other.gameObject.tag == "Esfera1" || other.gameObject.tag == "Jugador" || other.gameObject.tag == "Capsule"){ 

            CubeCounter = CubeCounter +1;
        }

    }
}

