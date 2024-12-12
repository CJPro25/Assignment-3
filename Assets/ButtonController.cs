using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public DoorController doorController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            doorController.ToggleDoor();
            gameObject.SetActive(false);
        }
    }

}
