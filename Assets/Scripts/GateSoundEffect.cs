using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSoundEffect : MonoBehaviour
{
    public AudioSource audioSource; // AudioSource bile�enine referans
    public AudioClip gateOpenSound; // Kap� a��lma sesi

    public void PlayGateOpenSound()
    {
        // E�er ses dosyas� ve AudioSource bile�eni varsa
        if (gateOpenSound != null && audioSource != null)
        {
            // Kap� a��lma sesini �al
            audioSource.PlayOneShot(gateOpenSound);
        }
        else
        {
            Debug.LogWarning("Kap� a��lma sesi veya AudioSource bile�eni bulunamad�.");
        }
    }
}
