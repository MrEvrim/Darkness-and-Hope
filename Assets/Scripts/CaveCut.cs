using UnityEngine;

public class CaveCut : MonoBehaviour
{
    public GameObject player; // Player objesi referansı
    public GameObject objectToActivate; // Aktive edilecek obje
    public GameObject NewCam;
    private void OnTriggerEnter(Collider other)
    {
        // Player objesi tespit edildiğinde
        if (other.CompareTag("Player"))
        {
          
            player.SetActive(false);

            NewCam.SetActive(true);
            objectToActivate.SetActive(true);
        }
    }
}
