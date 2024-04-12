using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons1 : MonoBehaviour
{
    public void Levelselect()
    {
        SceneManager.LoadScene("Level Selector");
    }

    public void Startgame()
    {
        SceneManager.LoadScene("Controls");
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
}
