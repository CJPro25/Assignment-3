using UnityEngine;
using UnityEngine.SceneManagement; // Required to manage scenes

public class ChangeSceneOnTouch : MonoBehaviour
{
    // Name of the scene to load
    [SerializeField] private string sceneName;

    // Check if the player enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Verify if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            Debug.Log("Tried to load scene");
            SceneManager.LoadScene(sceneName);
        }
    }
}
