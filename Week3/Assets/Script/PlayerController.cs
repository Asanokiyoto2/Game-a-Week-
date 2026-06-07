using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody rb;
    Vector3 move;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        move = new Vector3(h, 0, v).normalized;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
