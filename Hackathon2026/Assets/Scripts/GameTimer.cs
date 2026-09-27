using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    public PlayerStats stats;
    public TextMeshProUGUI timerText;
    public bool gameOver = false;

    void Update()
    {
        if(gameOver) return;

        stats.time -= Time.deltaTime;

        if(stats.time <= 0)
        {
            stats.time = 0;
            gameOver = true;
            TimeRanOut();
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        timerText.text = stats.time.ToString("F1");
    }

    void TimeRanOut()
    {
        Debug.Log("Time ran out, you died!)");
        //We can change this later to a scene or overlay
    }
}
