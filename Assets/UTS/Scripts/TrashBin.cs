using UnityEngine;

public class TrashBin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Interactable.IsHoldingObject)
            return;

        if (other.CompareTag("pickup"))
        {
            Destroy(other.gameObject);

            GameManager.Instance.AddTrash();
        }
    }
}