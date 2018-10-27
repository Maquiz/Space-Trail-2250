using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        Destroy(collision.gameObject);
    }
  
}
