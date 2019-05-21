using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
	private Vector3 pos0;
	int cnt;
    // Start is called before the first frame update
    void Start()
    {
		cnt = 0;
        pos0 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		//transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		//transform.position.y = cnt * 0.01;
		//transform.position = new Vector3(pos0.x, pos0.y+ (float)0.01*cnt ,pos0.z);
		transform.position = new Vector3(pos0.x, 
							pos0.y+ (float) 0.5f* Mathf.Sin(0.01f*cnt) ,
							//pos0.y+ (float) 0.5f* Mathf.Sin(Time.deltaTime) ,
							pos0.z);
		
		cnt = cnt+1;
    }
}
