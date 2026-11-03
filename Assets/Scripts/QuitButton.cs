using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class QuitButton : MonoBehaviour
{
    // This function loads your game scene
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    // This function quits the application
    public void QuitGame()
    {
        Debug.Log("Game is exiting..."); // Useful for testing in the Unity Editor
        Application.Quit();
    }
}