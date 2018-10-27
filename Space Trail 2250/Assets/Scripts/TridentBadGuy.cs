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
    private IEnumerator coroutine;
    ESTATE e;
    // Use this for initialization
    void Start () {
       // rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -2, 0), ForceMode.VelocityChange);
        e = ESTATE.INVISIBLE;
    }
	
	// Update is called once per frame
	void Update () {



    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            //Instantiate(BulletB, firepos.transform.position, Quaternion.identity);

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
        if (e == ESTATE.VISIBLE)
        {
            print("Should be shooting");
            //Instantiate(BulletB, firepos.transform.position, Quaternion.identity);
            coroutine = WaitAndShoot(1.0f);
            StartCoroutine(coroutine);

        }

    }
    // every 2 seconds perform the print()
    private IEnumerator WaitAndShoot(float waitTime)
    {

        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(BulletB, firepos.transform.position, Quaternion.identity);
        }
    }
}
