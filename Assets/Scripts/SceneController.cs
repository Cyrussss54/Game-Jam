using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class SceneController : MonoBehaviour
{
    // This function will be called when the button is pressed
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}