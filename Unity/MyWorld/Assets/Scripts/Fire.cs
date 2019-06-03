using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public GameObject bullet;

	// 발사 위치
	private Transform firePosition;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
			firePosition = this.transform;

            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }
    }
}
