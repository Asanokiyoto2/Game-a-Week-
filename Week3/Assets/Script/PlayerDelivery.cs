using UnityEngine;
using System.Collections;

public class PlayerDelivery : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DeliveryPoint point = other.GetComponent<DeliveryPoint>();
        if (point == null)
            return;
        Package package =
            DeliveryManager.Instance.carriedPackage;
        if (package == null)
            return;
        if (package.colorIndex == point.currentColorIndex)
        {
            package.gameObject.SetActive(false);
            DeliveryManager.Instance.carriedPackage = null;
            DeliveryManager.Instance.Deliver(
                point.currentColorIndex
            );
            StartCoroutine(
                RespawnPackage(package)
            );
        }
        
    }
    IEnumerator RespawnPackage(Package package)
    {
        yield return new WaitForSeconds(3f);
        float x = Random.Range(-12f, 12f);
        float z = Random.Range(-12f, 12f);
        package.transform.position =
            new Vector3(x, 0.5f, z);
        package.gameObject.SetActive(true);
    }
}

