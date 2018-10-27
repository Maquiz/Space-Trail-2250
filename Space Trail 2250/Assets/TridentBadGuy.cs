using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridentBadGuy : MonoBehaviour {

    public Rigidbody rb;
    public GameObject explosion;
    // Use this for initialization
    void Start () {
       // rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            print("I see the player");
            //This is where we shoot
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        print("Hit");
     
        Destroy(this.gameObject);
    }
}
