using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    private Rigidbody rb;
    public GameObject explosion;
    public GameObject smallAsteroid;
    public bool isBig;
    public int dmg;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
    }
	
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion,gameObject.transform.position, Quaternion.identity);
        print("Hit");
        audioSource.Play();
        if (isBig) {
            Instantiate(smallAsteroid, gameObject.transform.position, Quaternion.Euler(45,0,0));
        }
        if (collision.gameObject.tag == "Player") {
            FlightControl fc = collision.gameObject.GetComponent<FlightControl>();
            fc.takeDamage(dmg);
        }
        Destroy(this.gameObject);
    }
}
