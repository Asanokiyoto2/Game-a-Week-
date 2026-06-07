using UnityEngine;
using TMPro;
public class DeliveryManager : MonoBehaviour
{
    public static DeliveryManager Instance;
    [Header("îzíBêÊ")]
    public DeliveryPoint deliveryPoint;
    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text currentText;
    int currentPackageIndex = -1;
    int score = 0;
    public Package carriedPackage;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        deliveryPoint.ChangeColor();
        UpdateUI();
    }
    public void PickPackage(int index)
    {
        currentPackageIndex = index;
        UpdateUI();
    }
    public void Deliver(int index)
    {
        if (currentPackageIndex == -1)
            return;
        if (currentPackageIndex == index)
        {
            score += 100;
            deliveryPoint.ChangeColor();
        }
        currentPackageIndex = -1;
        UpdateUI();
    }
    void UpdateUI()
    {
        scoreText.text = "Score : " + score;
        if (currentPackageIndex == -1)
            currentText.text = "éùÇøï® : Ç»Çµ";
        else
            currentText.text = "éùÇøï® : " + ColorName(currentPackageIndex);
    }
    string ColorName(int index)
    {
        switch (index)
        {
            case 0: return "ê‘";
            case 1: return "ê¬";
            case 2: return "óŒ";
        }
        return "Ç»Çµ";
    }
}
