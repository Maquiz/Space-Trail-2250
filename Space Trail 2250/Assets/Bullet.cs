using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 10, 0), ForceMode.VelocityChange);
    }
	

    private void OnCollisionEnter(Collision collision)
    {
      /*  Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        print("Hit");
        if (isBig)
        {
            Instantiate(smallAsteroid, gameObject.transform.position, Quaternion.identity);
        }*/
        Destroy(this.gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
