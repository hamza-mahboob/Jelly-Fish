using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public TextMeshProUGUI text, timerText;
    int score, timeToShow;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        timer = 20;
    }

    // Update is called once per frame
    void Update()
    {
        //set text
        timer -= Time.deltaTime;
        text.text = "Score: " + score.ToString();
        timeToShow = (int)timer;
        timerText.text = "Time: " + timeToShow.ToString();
        //game over condition
        if (timer <= 0)
        {
            GameOver();
        }
    }

    public void addScore()
    {
        score += 5;
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);

    }

    public void RestartButton()
    {
        
        //loads current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
