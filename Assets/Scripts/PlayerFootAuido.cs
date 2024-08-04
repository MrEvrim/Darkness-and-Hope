using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootAuido : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    public AudioSource audioSource;
    public float footstepDelay = 0.5f;
    private float lastFootstepTime = 0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Time.time - lastFootstepTime > footstepDelay)
            {
                PlayFootstepSound();
                lastFootstepTime = Time.time;
            }
        }
    }

    void PlayFootstepSound()
    {
        audioSource.clip = footstepSounds[Random.Range(0, footstepSounds.Length)];
        audioSource.Play();
    }
}
