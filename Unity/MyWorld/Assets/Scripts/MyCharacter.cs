using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class MyCharacter : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	public AudioSource sound1;

	public Text cntText1;
	int cnt1;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
		cnt1 = 0;
		
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.JoystickButton0)) {
             Debug.Log("Character JoystickButton0!!");
			 
        }
		else if (Input.GetKeyDown(KeyCode.JoystickButton1)) {
             Debug.Log("Character JoystickButton1!!"); 
			 sound1.Play();
        }
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			//Destroy(other.gameObject);
			
			cnt1 = cnt1+1;
			sound1.Play();
		}
	}
}
