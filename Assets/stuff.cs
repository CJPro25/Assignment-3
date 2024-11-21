using UnityEngine;

public class stuff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("The game did start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("An update");
    }


    void Invoke()
    {
        Debug.Log("I invoke the fifth");
    }

    void OnGUI()
    {
        Debug.Log("guigui");
    }
}
