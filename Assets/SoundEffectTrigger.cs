using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundEffectTrigger : MonoBehaviour
{
    public AudioClip soundEffect;
    public float volume = 0.20f;
    public bool loop = false;
    public bool playOnAwake = false;
    public bool destroyAfterPlay = false;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundEffect;
        audioSource.volume = volume;
        audioSource.loop = loop;
        audioSource.playOnAwake = playOnAwake;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }

    public void Play()
    {
        
        audioSource.Play();
        if (destroyAfterPlay)
        {
            Destroy(gameObject, soundEffect.length);
        }
    }
}
