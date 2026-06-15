using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public Transform doorPivot;

    private bool playerNear = false;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    public float openSpeed = 2f;

    void Start()
    {
        closedRotation = doorPivot.rotation;

        openRotation = Quaternion.Euler(
            doorPivot.eulerAngles + new Vector3(0, -90f, 0)
        );
    }

    void Update()
    {
        if (playerNear)
        {
            doorPivot.rotation = Quaternion.Slerp(
                doorPivot.rotation,
                openRotation,
                Time.deltaTime * openSpeed
            );
        }
        else
        {
            doorPivot.rotation = Quaternion.Slerp(
                doorPivot.rotation,
                closedRotation,
                Time.deltaTime * openSpeed
            );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}