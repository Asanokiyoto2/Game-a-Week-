using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text timerText;
    public TMP_Text scoreText;

    public GameObject resultPanel;
    public TMP_Text resultText;

    public float timeLimit = 60f;

    int score = 0;


    bool gameEnd = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        resultPanel.SetActive(false);
    }

    void Update()
    {
        if (gameEnd) return;

        timeLimit -= Time.deltaTime;

        timerText.text = "Time : " + Mathf.Ceil(timeLimit);

        if (timeLimit <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;

        scoreText.text = "Score : " + score;
    }

    

    public void GameClear()
    {
        gameEnd = true;

        resultPanel.SetActive(true);

        resultText.text =
            "CLEAR\nScore : " + score;

        Time.timeScale = 0;
    }

    void GameOver()
    {
        gameEnd = true;

        resultPanel.SetActive(true);

        resultText.text =
            "GAME OVER\nScore : " + score;

        Time.timeScale = 0;
    }
}
