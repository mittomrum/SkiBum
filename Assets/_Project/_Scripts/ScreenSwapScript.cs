using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwapScript : MonoBehaviour
{
    public int sceneToLoad = 1;     // Set this to the name of your main menu scene
    [Range(0.09f, 0.13f)] public float animationSpeed = 0.09f;

    //search child for animation and play it using a speed of 1, if no animation send Debug.LogWarning();
    void Start()
    {
        if (GetComponentInChildren<Animator>() == null)
        {
            Debug.LogWarning("No animation found on " + gameObject.name);
            return;
        }
    }
    void Update()
    {
        GetComponentInChildren<Animator>().speed = animationSpeed;
        //change to space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
