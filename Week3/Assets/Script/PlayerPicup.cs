using UnityEngine;
public class PlayerPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Package p = other.GetComponent<Package>();
        if (p != null)
        {
            DeliveryManager.Instance.PickPackage(p.colorIndex);
        }
    }
}
