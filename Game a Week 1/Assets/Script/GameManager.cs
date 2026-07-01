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

    int totalCoins = 0;   // Å©í«â¡
    int getCoins = 0;     // Å©í«â¡

    bool gameEnd = false;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;
        resultPanel.SetActive(false);

        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    void Update()
    {
        if (gameEnd) return;

        timeLimit -= Time.deltaTime;
        timerText.text = $"Time : {Mathf.Ceil(timeLimit)}";

        if (timeLimit <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int amount)
    {
        if (gameEnd) return;

        score += amount;
        getCoins += amount;

        scoreText.text = $"Score : {score}";

        CheckClear(); // Å©Ç±Ç±èdóv
    }

    void CheckClear()
    {
        if (getCoins >= totalCoins && !gameEnd)
        {
            Invoke("GameClear", 0.5f); // è≠Çµä‘Çì¸ÇÍÇÈ
        }
    }

    public void GameClear()
    {
        if (gameEnd) return;

        gameEnd = true;
        resultPanel.SetActive(true);

        resultText.text = $"CLEAR\nScore : {score}";
        Time.timeScale = 0f;
    }

    void GameOver()
    {
        if (gameEnd) return;

        gameEnd = true;
        resultPanel.SetActive(true);

        resultText.text = $"GAME OVER\nScore : {score}";
        Time.timeScale = 0f;
    }
}
