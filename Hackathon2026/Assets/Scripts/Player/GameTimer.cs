using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    public PlayerStats stats;
    public TextMeshProUGUI timerText;
    public bool gameOver = false;

    public Transform playerTransform;
    public Vector3 startPosition;

    void Start()
    {
        playerTransform = stats.transform;
        startPosition = playerTransform.position;
    }
    void Update()
    {
        if(gameOver) return;

        stats.time -= Time.deltaTime;

        if(stats.time <= 0)
        {
            stats.time = 0;
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
        playerTransform.position = startPosition;
        stats.time = stats.GetMaxTime();
        //Debug.Log("Time ran out, you died!)");
        //We can change this later to a scene or overlay
    }
}
