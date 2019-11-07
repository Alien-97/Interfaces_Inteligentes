using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // Use this for initialization
	void Start () {
        GameController.CambioLuz += CambiarLuz;
    }

    public void CambiarLuz(){
        Light myLight = GetComponent<Light>();
        //myLight.enabled = !myLight.enabled;
        myLight.intensity = 0;
    }
}
