using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveTrigger : MonoBehaviour
{
    public int sceneToLoad = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
