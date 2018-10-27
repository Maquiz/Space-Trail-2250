using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuStartScreen : MonoBehaviour {

    public void goNextScene() {
        SceneManager.LoadScene("TransportationPhase");
    }
}
