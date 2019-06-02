using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * bulletSpeed * Time.deltaTime;
    }
}
