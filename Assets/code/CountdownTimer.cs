using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        timeIsRunning = true;
    }
    void Update()
    {
       if(timeRemaining >= 0) { 
            timeRemaining += Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        if (timeRemaining >= 420) //weed number lol
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads the next scene (aka the main game)
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
