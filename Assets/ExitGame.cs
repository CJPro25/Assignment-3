using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape") == true)
        {
#if UNITY_EDITOR
        Debug.Log("Tried to quit");
        UnityEditor.EditorApplication.isPlaying = false;  // This stops the play mode in the Unity editor
#else
            Application.Quit(); // Quit the game in a built version
#endif
        }
    }
}
