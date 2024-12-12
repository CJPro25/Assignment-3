using UnityEngine;
/*
public class PlayerRotation : MonoBehaviour
{
    public float sensitivity = 100f; // Mouse sensitivity for horizontal rotation
    public Transform playerBody; // Reference to the player's body for rotation
    public Transform playerHead; // Reference to the player's head for rotation

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;

        Cursor.lockState = CursorLockMode.Locked;


        // Get mouse movement on the X-axis (left and right)
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        // Get mouse movement on the Z-axis (up and down)
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate the player body around the X-axis (horizontal rotation)
        playerBody.Rotate(Vector3.up * mouseX);

        // Rotate the player head around the Y-axis (vertical rotation)
        playerHead.Rotate(Vector2.left * mouseY);


    }
}*/



public class PlayerRotation : MonoBehaviour
{
    public float sensitivity = 100f; // Mouse sensitivity for rotation
    public Transform playerBody; // Reference to the player's body for horizontal rotation
    public Transform playerHead; // Reference to the player's head for vertical rotation

    private float verticalRotation = 0f; // Keeps track of the head's current vertical rotation

    void Update()
    {
        // Unlock cursor with Escape key
        if (Input.GetKey(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;

        // Lock cursor for gameplay
        Cursor.lockState = CursorLockMode.Locked;

        // Get mouse input for rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate the player body around the Y-axis (horizontal rotation)
        playerBody.Rotate(Vector3.up * mouseX);

        // Update vertical rotation and clamp it
        verticalRotation -= mouseY; // Subtract mouseY to invert mouse movement
        verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f); // Clamp between -80 and 80 degrees

        // Apply the clamped rotation to the player head
        playerHead.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}



