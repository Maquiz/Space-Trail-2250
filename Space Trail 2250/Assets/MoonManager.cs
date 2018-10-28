using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoonManager : MonoBehaviour {
    public GameObject dt;
    public Button introButton;
    public Text welcometext;
    public Button continueButton;
    public Text crystalText,crys;
    GameManager gm;
    public Button b1, b2, b3, b4, next;

    public int count = 0;

    // Use this for initialization
    void Start () {
       gm =  GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (count == 2)
        {
            introButton.gameObject.SetActive(false);
            crystalText.gameObject.SetActive(true);
            b1.gameObject.SetActive(true);
            b2.gameObject.SetActive(true);
            b3.gameObject.SetActive(true);
            b4.gameObject.SetActive(true);
            crys.gameObject.SetActive(true);
            next.gameObject.SetActive(true);
            crystalText.text = gm.crystal.ToString();
        }
        
    }

    public void switchButtons() {

        welcometext.enabled = false;
        introButton.enabled = false;
        continueButton.gameObject.SetActive(true);
        
    }

    public void clickCount()
    {
   
        count++;
    }
    public void nextLevel() {
        SceneManager.LoadScene("Mars Transportaion");
    }

}
