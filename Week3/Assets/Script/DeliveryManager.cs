using UnityEngine;
using TMPro;
public class DeliveryManager : MonoBehaviour
{
    public static DeliveryManager Instance;
    [Header("â◊ï®")]
    public GameObject[] packages;
    [Header("îzíBêÊ")]
    public GameObject[] deliveryPoints;
    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text currentText;
    int currentPackageIndex = -1;
    int score = 0;
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        SpawnNext();
        UpdateUI();
    }
    void SpawnNext()
    {
        foreach (GameObject p in packages)
            p.SetActive(false);
        foreach (GameObject d in deliveryPoints)
            d.SetActive(false);
        int index = Random.Range(0, packages.Length);
        packages[index].SetActive(true);
        deliveryPoints[index].SetActive(true);
        currentPackageIndex = -1;
    }
    public void PickPackage(int index)
    {
        currentPackageIndex = index;
        packages[index].SetActive(false);
        UpdateUI();
    }
    public void Deliver(int index)
    {
        if (currentPackageIndex == -1)
            return;
        if (currentPackageIndex == index)
        {
            score += 100;
            scoreText.text = "Score : " + score;
            SpawnNext();
        }
        currentPackageIndex = -1;
        UpdateUI();
    }
    void UpdateUI()
    {
        if (currentPackageIndex == -1)
            currentText.text = "éùÇøï® : Ç»Çµ";
        else
            currentText.text = "éùÇøï® : " + currentPackageIndex;
    }
}
