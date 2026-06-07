using UnityEngine;
public class PlayerDelivery : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DeliveryPoint d = other.GetComponent<DeliveryPoint>();
        if (d != null)
        {
            DeliveryManager.Instance.Deliver(d.colorIndex);
        }
    }
}
