using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartCurrentScene();
        }
    }

    public void RestartCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene(); //Get the current scene
        SceneManager.LoadScene(currentScene.name); // Reload the scene by its name
    }
}
