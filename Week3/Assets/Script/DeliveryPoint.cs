using UnityEngine;
public class DeliveryPoint : MonoBehaviour
{
    public int currentColorIndex;
    Renderer rend;
    void Awake()
    {
        rend = GetComponent<Renderer>();
    }
    public void ChangeColor()
    {
        currentColorIndex = Random.Range(0, 3);
        switch (currentColorIndex)
        {
            case 0:
                rend.material.color = Color.red;
                break;
            case 1:
                rend.material.color = Color.blue;
                break;
            case 2:
                rend.material.color = Color.green;
                break;
        }
    }
}
