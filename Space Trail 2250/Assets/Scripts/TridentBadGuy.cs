using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridentBadGuy : MonoBehaviour {

    public Rigidbody rb;
    public GameObject explosion;
    public GameObject BulletB;
    public Transform firepos;
    public int dmg;
    public enum ESTATE { INVISIBLE, VISIBLE, DEAD };
    ESTATE e;
    // Use this for initialization
    void Start () {
       // rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
        e = ESTATE.INVISIBLE;
    }
	
	// Update is called once per frame
	void Update () {
        if (e == ESTATE.VISIBLE) {
           // Instantiate(BulletB, firepos.transform.position, Quaternion.identity);
        }


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
        if (collision.gameObject.tag == "Player")
        {
            FlightControl fc = collision.gameObject.GetComponent<FlightControl>();
            fc.takeDamage(dmg);
        }
        Destroy(this.gameObject);
    }

    public void OnBecameVisible()
    {
        e = ESTATE.VISIBLE;
   
    }
}
