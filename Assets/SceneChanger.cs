using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Scene 1");
    }
}
