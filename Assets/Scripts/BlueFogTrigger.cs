using UnityEngine;

public class BlueFogTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RenderSettings.fog = true;
            //mavimtırak
            RenderSettings.fogColor = new Color32(0, 27, 125, 255);

            RenderSettings.fogDensity = 0.003f;
        }
    }
}