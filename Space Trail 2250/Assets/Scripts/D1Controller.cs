using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1Controller : MonoBehaviour {
    public GameObject d;
    private DialogueTrigger dt;
	// Use this for initialization
	void Start () {

        dt = d.GetComponent<DialogueTrigger>();
        dt.TriggerDialogue();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
