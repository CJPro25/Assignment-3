using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float sensitivity = 100f; // Mouse sensitivity for horizontal rotation
    public Transform playerBody; // Reference to the player's body for rotation
    public Transform playerHead; // Reference to the player's head for rotation

    void Update()
    {
        // Get mouse movement on the X-axis (left and right)
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        // Get mouse movement on the Z-axis (up and down)
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate the player body around the X-axis (horizontal rotation)
        playerBody.Rotate(Vector3.up * mouseX);

        // Rotate the player head around the Y-axis (vertical rotation)
        playerHead.Rotate(Vector2.left * mouseY);
    }
}


