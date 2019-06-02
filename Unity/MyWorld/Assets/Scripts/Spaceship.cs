using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
	private Vector3 pos0;
	int cnt;
	float ang_y;
    // Start is called before the first frame update
    void Start()
    {
		cnt = 0;
		ang_y = 0f;
        pos0 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		transform.rotation = Quaternion.Euler(-90,ang_y,-90);
		transform.position = new Vector3(pos0.x, 
							pos0.y+ (float) 0.5f* Mathf.Sin(0.01f*cnt) ,
							pos0.z);

		ang_y += Time.deltaTime * 20;
		cnt = cnt+1;
    }
}
