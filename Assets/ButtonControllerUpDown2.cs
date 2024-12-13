using UnityEngine;

public class ButtonControllerUpDown2 : MonoBehaviour
{
    public DoorController2 doorController2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorController2.ToggleDoor2();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorController2.ToggleDoor2();
        }
    }
}
