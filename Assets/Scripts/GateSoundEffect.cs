using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSoundEffect : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource bileþenine referans
    public AudioClip gateOpenSound; // Kapý açýlma sesi

    public void PlayGateOpenSound()
    {
        // Eðer ses dosyasý ve AudioSource bileþeni varsa
        if (gateOpenSound != null && audioSource != null)
        {
            // Kapý açýlma sesini çal
            audioSource.PlayOneShot(gateOpenSound);
        }
        else
        {
            Debug.LogWarning("Kapý açýlma sesi veya AudioSource bileþeni bulunamadý.");
        }
    }
}
