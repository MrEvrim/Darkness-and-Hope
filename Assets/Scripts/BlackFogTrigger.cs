using UnityEngine;

public class BlackFogTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RenderSettings.fog = true;

            RenderSettings.fogColor = Color.black;

            RenderSettings.fogDensity = 0.2f;
        }
    }
}