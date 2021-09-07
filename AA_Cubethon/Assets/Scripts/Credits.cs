using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject OptionScreen;

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MenuScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void Instructions()
    {
        StartScreen.SetActive(false);
        OptionScreen.SetActive(true);
    }

    public void TitleScreen()
    {
        StartScreen.SetActive(true);
        OptionScreen.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
