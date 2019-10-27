using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementSphere : MonoBehaviour
{
	public Rigidbody rb;
    public Vector3 direccionRandom;
    public float speed = 4;
    public float ultimoCambioDireccion = 0;
    public float tiempoCambioDireccion = 1;
    // Start is called before the first frame update
    void Start()
    {

    	rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	if (Time.time - ultimoCambioDireccion > tiempoCambioDireccion)
        {
            direccionRandom = new Vector3(Random.onUnitSphere.x * 2, 0, Random.onUnitSphere.z * 2); // genera una posición nueva, aleatoriamente
            ultimoCambioDireccion = Time.time;
        }
        // aplica la dirección en cada frame al rigidbody
        rb.MovePosition(rb.position + direccionRandom * Time.fixedDeltaTime * speed);  
    }
}
