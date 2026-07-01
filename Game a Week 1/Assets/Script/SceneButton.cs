using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    // タイトルへ
    public void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }

    // リトライ
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");
    }

    // ゲーム終了（ビルド時のみ）
    public void QuitGame()
    {
        Application.Quit();
    }
}
