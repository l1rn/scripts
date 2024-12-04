using UnityEngine;

public class ExitScript : MonoBehaviour
{
    [SerializeField] PauseScript pauseScript;
    private void Awake()
    {
        pauseScript = FindAnyObjectByType<PauseScript>();
    }
    void Update()
    {
        if(pauseScript.enabled == true)
        {
            Application.Quit();
        }
    }
}
