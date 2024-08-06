using UnityEngine;

public class OneTimeToggleWithDelay : MonoBehaviour
{
    public Camera cameraToToggle; // Bağlanacak kamera
    public float offDuration = 2f; // Kameranın kapalı kalma süresi (saniye)

    private bool hasToggled = false;

    void Start()
    {
        if (cameraToToggle == null)
        {
            Debug.LogError("Kamera atanmadı!");
            return;
        }

        // Kamerayı hemen kapat
        cameraToToggle.gameObject.SetActive(false);
        hasToggled = true;

        // Belirli bir süre sonra kamerayı tekrar aç
        Invoke("ReactivateCamera", offDuration);
    }

    void ReactivateCamera()
    {
        if (hasToggled)
        {
            cameraToToggle.gameObject.SetActive(true);
        }
    }
}
