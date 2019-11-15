using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectA : MonoBehaviour {

    // Use this for initialization

    public int poder;

    private Transform tf;
    private Renderer rend; 

    void Start()
    {
        poder = 100;
        GameController.Atacar += AtacarObjeto;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        GameController.ReducirPoder();
        transform.localScale += new Vector3(0, -0.25F, 0);
    }

    private void AtacarObjeto(int energia){

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

}