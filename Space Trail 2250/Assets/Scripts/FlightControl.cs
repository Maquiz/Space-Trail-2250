using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightControl : MonoBehaviour {


    private Rigidbody rb;
    public GameObject bullet;
    public GameObject gun1, gun2;
    public enum PSTATE { ALIVE, DEAD };
    public PSTATE playerlife;
    private GameManager gm;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
        playerlife = PSTATE.ALIVE;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            //move left
            rb.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            //move right
            rb.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
        }
        if (gm.ammo > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bullet, gun1.transform.position, Quaternion.identity);
                Instantiate(bullet, gun2.transform.position, Quaternion.identity);
                gm.ammo -= 2;
            }
        }

    }


    public void takeDamage(int dmg) {
        gm.food -= dmg;
        print("Player took" + dmg + "damage");
    }
    public void getPowerUp(int type, int amount)
    {
        if (type == 0) {
            gm.crystal += amount;
        }
    }
    public void Shoot(){
        Instantiate(bullet, gun1.transform.position, Quaternion.identity);
        Instantiate(bullet, gun2.transform.position, Quaternion.identity);
        gm.ammo -= 2;
    }
    public void moveLeft() {
        rb.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);
    }
    public void moveRight() {
        rb.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);
    }


}
