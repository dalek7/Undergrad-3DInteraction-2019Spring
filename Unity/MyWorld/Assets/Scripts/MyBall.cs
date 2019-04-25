using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	public AudioSource sound1;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = 10;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
		float jump = 0.0f;
		
		if (Input.GetKeyDown("space"))
        {
            jump = 20.0f;
        }

        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(mh, jump, mv);
        rb.AddForce(movement * speed);

    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			//Destroy(other.gameObject);
			
			sound1.Play();
		}
	}
}
