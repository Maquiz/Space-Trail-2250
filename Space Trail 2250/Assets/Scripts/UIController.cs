using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    private GameManager gm;
    public Text ammoCount;
    public Text crystalCount;
    public Slider health, energy, oxygen;
    private IEnumerator coroutine, coroutine2;

    // Use this for initialization
    void Start () {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
        coroutine = WaitAndShoot(1.0f);
        StartCoroutine(coroutine);
        coroutine2 = OxyWaitAndShoot(1.0f);
        StartCoroutine(coroutine2);
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
        energy.value = ((float)gm.fuel / (float)gm.maxFuel);
        }
    private IEnumerator WaitAndShoot(float waitTime)
    {

        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            gm.fuel -= .5f;
        }
    }
    private IEnumerator OxyWaitAndShoot(float waitTime)
    {

        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            gm.fuel -= .5f;
        }
    }
}
