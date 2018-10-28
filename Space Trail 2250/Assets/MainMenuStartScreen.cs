using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuStartScreen : MonoBehaviour {
    public Button b1;
    public Button b2;
    public Button b3;
    public int count = 0;


    private void Update()
    {
        if (count == 2) {
            b2.gameObject.SetActive(false);
            b3.gameObject.SetActive(true);
        }
    }
    public void switchButton()
    {
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(true);
    }

    public void clickCount() {

        count++;
    }

    public void goNextScene() {
        SceneManager.LoadScene("TransportationPhase");
    }
}
