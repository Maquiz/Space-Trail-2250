using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    private Rigidbody rb;
    public int powerType;

// Use this for initialization
void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
 
        if (collision.gameObject.tag == "Player")
        {
            FlightControl fc = collision.gameObject.GetComponent<FlightControl>();
            fc.getPowerUp(0,100);
        }
        Destroy(this.gameObject);
    }
}
