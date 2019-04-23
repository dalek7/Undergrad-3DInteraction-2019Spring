using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;


public class MyBall : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
	

	private int count1;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = 10;
		
        //joystick = FindObjectOfType<Joystick>();
    }


    // Update is called once per frame

    void Update()
    {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement1 = new Vector3(moveHorizontal, 0, moveVertical);
		rb.AddForce(movement1 * speed);
		
    }

}