using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape") == true)
        {
            SceneManager.LoadScene("Scene 0");
        }
    }
}
