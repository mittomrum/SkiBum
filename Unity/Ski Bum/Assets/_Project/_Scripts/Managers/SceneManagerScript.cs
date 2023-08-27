using UnityEngine;
using UnityEngine.SceneManagement;


// uses onclick form button group for change scenes when pressed
public class SceneManagerScript : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
