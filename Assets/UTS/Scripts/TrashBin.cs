using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public int trashCount = 0;
    public int totalTrash = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (Interactable.IsHoldingObject)
            return;

        if (other.CompareTag("pickup"))
        {
            trashCount++;

            Destroy(other.gameObject);

            Debug.Log("Trash Collected: " + trashCount);

            if (trashCount >= totalTrash)
            {
                Debug.Log("YOU WIN!");

                Time.timeScale = 0;
            }
        }
    }
}