using UnityEngine;
public class DeliveryPointLight : MonoBehaviour
{
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        float emission = Mathf.PingPong(Time.time * 3f, 2f);
        rend.material.SetColor(
            "_EmissionColor",
            Color.white * emission
        );
    }
}
