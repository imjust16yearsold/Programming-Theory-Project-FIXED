using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Get the index of the currently active scene and add 1
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(nextSceneIndex + 1);
    }
    public void Finish()
    {
        SceneManager.LoadScene(0);
    }
}
