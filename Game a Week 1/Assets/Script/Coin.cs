using UnityEngine;

public class Coin : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // ‰ñ“]
        transform.Rotate(0, 180f * Time.deltaTime, 0);

        // ‚Ó‚í‚Ó‚í•‚‚­
        transform.position =
            startPos +
            Vector3.up * Mathf.Sin(Time.time * 2f) * 0.2f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
