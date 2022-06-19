using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameoverCanvas;
    public GameObject Meuncanvus;
    public bool isGame = true;
    public bool isMove = true;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void Gameover()
    {
        isGame = false;
        isMove = false;
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0;
        Meuncanvus.SetActive(false);
    }
    public void Replay()
    {
        isMove = true;
        SceneManager.LoadScene(1);
        isGame = true;
    }
    public void Statgame()
    {
        SceneManager.LoadScene(1);
    }
    public void PauseGame()
    {
        isGame = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isMove = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGame = true;
        isMove = true;
    }

}
