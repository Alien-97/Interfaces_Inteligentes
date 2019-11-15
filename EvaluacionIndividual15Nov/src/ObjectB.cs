using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectB : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //GameController.ReduccionPoder += ReducirPoder;
    }

    private void ReducirPoder()
    {
        transform.localScale += new Vector3(0, 0.5F, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        GameController.ReducirPoder();
    }
}
