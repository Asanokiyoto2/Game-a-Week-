using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TimerManager : MonoBehaviour
{
    public TMP_Text timerText;
    public float timeLimit = 60f;
    void Update()
    {
        timeLimit -= Time.deltaTime;
        timerText.text = "Time : " + Mathf.Ceil(timeLimit);
        if (timeLimit <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
