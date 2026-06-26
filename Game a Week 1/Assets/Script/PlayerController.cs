using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 10f;
    public float deadLine = -10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);

        rb.AddForce(move * moveForce);
    }

    void Update()
    {
        if (transform.position.y < deadLine)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
