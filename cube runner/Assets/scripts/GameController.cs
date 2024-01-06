using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverpanel1;
    public GameObject tapToStart;
    public GameObject scoredisplay;

    private void Start()
    {
        scoredisplay.SetActive(false);
        tapToStart.SetActive(true);
        gameOverpanel1.SetActive(false);
        pausegame();
        
    }
    private void Update()
    {
        scoredisplay.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startgame();
        }

    }
    public void GameOver()
    {
        scoredisplay.SetActive(false);
        gameOverpanel1.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();


    }
    public void pausegame()
    {
        Time.timeScale = 0f;
    }
    public void startgame()
    {
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }

}
