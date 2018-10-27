using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Rigidbody rb;
    public bool isBad;
    public float speed;
    public int dmg;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        if (isBad)
        {
            rb.AddForce(new Vector3(0, -10, 0), ForceMode.VelocityChange);
        }
        else {
            rb.AddForce(new Vector3(0, speed, 0), ForceMode.VelocityChange);
        }
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (isBad) { 
        if (collision.gameObject.tag == "Player")
        {
            FlightControl fc = collision.gameObject.GetComponent<FlightControl>();
            fc.takeDamage(dmg);
        }
        }
        Destroy(this.gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
