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
    public float fuel,maxFuel;
    public float oxygen, maxOxygen;
    public int crystal;
    public int food,maxFood;
    public Canvas c;



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
        ammo = 400;
        maxFuel = 100;
        fuel = 100;
        maxOxygen = 100;
        oxygen = 100;
        crystal = 100;
        maxFood = 1000;
        food = 1000;

    }

    private void Update()
    {
        if(food <= 0 ){
            gameOver();

        } else if(oxygen <= 0)
        {

            gameOver();

        }
        else if (fuel <= 0)
        {

            gameOver();
        }
    }

    public void changeLevel(string name){

        SceneManager.LoadScene(name);
    }
    public void gameOver(){

        changeLevel("Main Menu");
        ammo = 400;
        maxFuel = 100;
        fuel = 100;
        maxOxygen = 100;
        oxygen = 100;
        crystal = 100;
        maxFood = 1000;
        food = 1000;

    }

    public void addAmmo(){
        if (crystal >= 10)
        {
            ammo += 100;
            crystal -= 10;
        }
    }
    public void addFuel()
    {
            if (crystal >= 10)
            {
                fuel += 100;
                crystal -= 10;
            }
    }
    public void addHealth()
    {
        if (crystal >= 10)
        {
            food += 100;
            crystal -= 10;
        }
    }

    public void addOxygen()
    {
        if (crystal >= 10)
        {
            oxygen += 100;
            crystal -= 10;
        }
    }
}


