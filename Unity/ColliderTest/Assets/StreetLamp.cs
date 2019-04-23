﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLamp : MonoBehaviour
{
	Light light1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
		light1= GetComponentInChildren<Light>(true);
    }
	private void OnTriggerEnter(Collider other)
    {
		light1.enabled = true;	
		Debug.Log("entered");
    }

	private void OnTriggerExit(Collider other)
	{
		light1.enabled = false;	
		Debug.Log("exit");
		//Destroy(other.gameObject);
	}

	 // Update is called once per frame
    void Update()
    {
    }


}
