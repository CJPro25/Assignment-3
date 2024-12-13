using UnityEngine;
using System.Collections; // Needed for IEnumerator

public class DoorController2 : MonoBehaviour
{
    public Transform doorTransform;  // The door to be moved
    public float openYPosition = 3f;  // The Y position where the door will move to (open position)
    public float closedYPosition = 0f; // The Y position where the door is initially (closed position)
    public float speed = 2f;         // Speed at which the door opens or closes
    private bool isOpen = false;     // Flag to track if the door is open
    private bool button1 = false;
    private bool button2 = false;

    // This will be called to move the door
    public void ToggleDoor2()
    {
        if (isOpen)
        {
            // Move the door back to the closed position along the Y-axis
            StopAllCoroutines();
            StartCoroutine(MoveDoor2(doorTransform.position.y, closedYPosition));
        }
        else
        {
            // Move the door to the open position along the Y-axis
            StopAllCoroutines();
            StartCoroutine(MoveDoor2(doorTransform.position.y, openYPosition));
        }
        isOpen = !isOpen;  // Toggle the state of the door
    }

    // Coroutine to smoothly move the door along the Y-axis
    private IEnumerator MoveDoor2(float startYPosition, float targetYPosition)
    {
        float timeElapsed = 0f;
        Vector3 currentPosition = doorTransform.position;  // Get the current position

        while (timeElapsed < 1f)
        {
            float newYPosition = Mathf.Lerp(startYPosition, targetYPosition, timeElapsed);
            doorTransform.position = new Vector3(currentPosition.x, newYPosition, currentPosition.z); // Keep X and Z, change only Y
            timeElapsed += Time.deltaTime * speed;
            yield return null; // Wait until the next frame
        }

        // Ensure the door reaches the target Y position
        doorTransform.position = new Vector3(currentPosition.x, targetYPosition, currentPosition.z);
    }
}
