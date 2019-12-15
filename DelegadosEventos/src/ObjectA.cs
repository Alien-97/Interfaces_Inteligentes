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
        GameController.Atacar +=
        poder = 100;

        tf = GetComponent<Transform> ();
        rend = GetComponent<Renderer>();
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


}