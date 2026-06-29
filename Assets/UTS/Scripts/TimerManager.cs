using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public float timeRemaining = 120f;

    public TMP_Text timerText;

    private bool timerRunning = true;

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

                UpdateTimer();
            }
            else
            {
                timeRemaining = 0;

                timerRunning = false;

                GameOver();
            }
        }
    }

    void UpdateTimer()
    {
        int seconds = Mathf.FloorToInt(timeRemaining);

        timerText.text = "Time: " + seconds;
    }

    void GameOver()
    {
        timerText.text = "GAME OVER";

        Debug.Log("GAME OVER");
    }
}