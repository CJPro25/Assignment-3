using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void quitTheGame()
    {
        // If we're in the Unity Editor, stop playing the scene
#if UNITY_EDITOR
        Debug.Log("Tried to quit");
        UnityEditor.EditorApplication.isPlaying = false;  // This stops the play mode in the Unity editor
#else
            Application.Quit(); // Quit the game in a built version
#endif
    }
}