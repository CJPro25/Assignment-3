using UnityEngine;

public class ButtonControllerUpDown : MonoBehaviour
{
    public DoorController doorController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorController.ToggleDoor();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorController.ToggleDoor();
        }
    }
}
