using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBox : MonoBehaviour {

    private GameManager gm;
    public string nextPlace;
    public bool isCalaminity;
	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player"){

            if(!isCalaminity){
                gm.changeLevel(nextPlace);
                print("mars");
            }
        }
    }
}
