using UnityEngine;

public class CaveCut : MonoBehaviour
{
    public GameObject player; // Player objesi referansı
    public GameObject objectToActivate; // Aktive edilecek obje

    private void OnTriggerEnter(Collider other)
    {
        // Player objesi tespit edildiğinde
        if (other.CompareTag("Player"))
        {
            // Player objesini deaktif et
            player.SetActive(false);

            // Başka bir objeyi aktive et
            objectToActivate.SetActive(true);
        }
    }
}
