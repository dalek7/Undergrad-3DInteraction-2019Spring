using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class MyBall : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	public AudioSource sound1;

	public Text cntText1;
	int cnt1;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = 10;
		cnt1 = 0;
		
		Debug.Log(SceneManager.GetActiveScene().name);

		if(SceneManager.GetActiveScene().name =="PickupTest")
		{
			cntText1.text = "Count: " + cnt1.ToString();
		}
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
		
		if(SceneManager.GetActiveScene().name =="PickupTest")
		{
			cntText1.text = "Count: " + cnt1.ToString();
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
