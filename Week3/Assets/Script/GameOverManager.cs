using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text =
            "Score : " + DeliveryManager.finalScore;
    }
}
