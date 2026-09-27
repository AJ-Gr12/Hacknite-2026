using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool gameOver = false;

    public Transform playerTransform;
    public Vector3 startPosition;

    void Start()
    {
        startPosition = playerTransform.position;
    }
    void Update()
    {
        if(gameOver) return;

        PlayerStats.time -= Time.deltaTime;

        if(PlayerStats.time <= 0)
        {
            PlayerStats.time = 0;
            TimeRanOut();
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        timerText.text = PlayerStats.time.ToString("F1");
    }

    void TimeRanOut()
    {
        PlayerStats.time = PlayerStats.GetMaxTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Debug.Log("Time ran out, you died!)");
        //We can change this later to a scene or overlay
    }
}
