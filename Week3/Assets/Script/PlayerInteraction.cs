using UnityEngine;
public class PlayerInteraction : MonoBehaviour
{
    Package nearbyPackage;
    void Update()
    {
        // 持つ・置く
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 持っていない → 持つ
            if (DeliveryManager.Instance.carriedPackage == null)
            {
                if (nearbyPackage != null)
                {
                    CarryPackage(nearbyPackage);
                }
            }
            // 持っている → 置く
            else
            {
                DropPackage();
            }
        }
        // 持っている荷物をプレイヤーの上に表示
        if (DeliveryManager.Instance.carriedPackage != null)
        {
            DeliveryManager.Instance.carriedPackage.transform.position =
                transform.position + Vector3.up * 1.5f;
        }
    }
    void CarryPackage(Package package)
    {
        DeliveryManager.Instance.carriedPackage = package;
        package.isCarried = true;
        DeliveryManager.Instance.PickPackage(
            package.colorIndex
        );
    }
    void DropPackage()
    {
        Package package = DeliveryManager.Instance.carriedPackage;
        package.isCarried = false;
        package.transform.position =
            transform.position + transform.forward;
        DeliveryManager.Instance.carriedPackage = null;
    }
    private void OnTriggerEnter(Collider other)
    {
        Package package = other.GetComponent<Package>();
        if (package != null)
        {
            nearbyPackage = package;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Package package = other.GetComponent<Package>();
        if (package != null)
        {
            nearbyPackage = null;
        }
    }
}
