using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLampOld : MonoBehaviour
{
    // Start is called before the first frame update
	Light light1;

    void Start()
    {
		light1= GetComponentInChildren<Light>(true);
		Debug.Log(light1.enabled);

		light1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
    {
	
		Debug.Log("entered");
		//Debug.Log(other.gameObject.name);
		light1.enabled = true;
		
    }

	private void OnTriggerExit(Collider other)
	{
		
		Debug.Log("exit");
		light1.enabled = false;
		//Destroy(other.gameObject);
		
	}

}
