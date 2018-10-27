using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    private Rigidbody rb;
    public GameObject explosion;
    public GameObject smallAsteroid;
    public bool isBig;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
    }
	
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion,gameObject.transform.position, Quaternion.identity);
        print("Hit");
        if (isBig) {
            Instantiate(smallAsteroid, gameObject.transform.position, Quaternion.Euler(45,0,0));
        }
        Destroy(this.gameObject);
    }
}
