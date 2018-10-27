using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightControl : MonoBehaviour {

    public int health;
    private Rigidbody rb;
    public GameObject bullet;
    public GameObject gun1, gun2;
    public enum PSTATE { ALIVE, DEAD };
    public PSTATE playerlife;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

        playerlife = PSTATE.ALIVE;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            //move left
            rb.AddForce(new Vector3(-5,0,0),ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            //move right
            rb.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, gun1.transform.position, Quaternion.identity);
            Instantiate(bullet, gun2.transform.position, Quaternion.identity);
        }
        if (health <= 0) {
            playerlife = PSTATE.DEAD;
        }
    }


    public void takeDamage(int dmg) {
        health -= dmg;
        print("Player took" + dmg +"damage");
    }

}
