using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Method to start the game
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    // Method to load the options menu
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    // Method to exit the game
    public void Exit()
    {
        Application.Quit();
    }
}

