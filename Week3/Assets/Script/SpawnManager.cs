using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    public Transform[] packageSpawns;
    public Transform[] deliverySpawns;
    public float spawnInterval = 10f;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0;
            spawnInterval =
                Mathf.Max(2f, spawnInterval - 0.5f);
            DeliveryManager.Instance.SendMessage("SpawnNext");
        }
    }
}
