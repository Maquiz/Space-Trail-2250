using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
                                                            // private BoardManager boardScript;                       //Store a reference to our BoardManager which will set up the level.
    public GameObject Player;
    public int ammo;
    public float fuel;
    public float oxygen;
    public int crystal;
    public int food;



    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        //boardScript.SetupScene(level);
        //load start scene
        ammo = 500;
        fuel = 100;
        oxygen = 100;
        crystal = 1000;
        food = 100;
    }

    public void changeLevel(string name){

        SceneManager.LoadScene(name);
    }

}


