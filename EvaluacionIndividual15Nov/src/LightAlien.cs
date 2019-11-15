using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAlien : MonoBehaviour {

	public Light myLight;
	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light>();
        GameController.CambioLuz += CambiarLuz;
    }

    void CambiarLuz()
    {
        myLight.enabled = !myLight.enabled;
    }
}
