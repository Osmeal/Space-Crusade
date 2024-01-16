using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Se añade para poder acceder a SceneManager

public class SceneController : MonoBehaviour
{
    public GameObject canvasGameOver;
    public GameObject canvasGameStart;
    public GameObject explosion;

    void Start()
    {
        Time.timeScale = 0;
    }
    public void gameOver()
    {
        explosion.SetActive(true);
        canvasGameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void gameReset()
    {
        SceneManager.LoadScene(0);
    }
    public void gameStart()
    {
        canvasGameStart.SetActive(false);
        Time.timeScale = 1;
    }
    public void gameExit()
    {
        Application.Quit();
    }
}
