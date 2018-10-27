using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    private GameManager gm;
    public Text ammoCount;
    public Text crystalCount;
    public Slider health, energy, oxygen;

    // Use this for initialization
    void Start () {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (ammoCount != null)
        {
            ammoCount.text = gm.ammo.ToString();
        }
        if(crystalCount != null){
            crystalCount.text = gm.crystal.ToString();
        }
        print(gm.food / gm.maxFood);
        health.value =  ((float)gm.food / (float)gm.maxFood);
        }
}
