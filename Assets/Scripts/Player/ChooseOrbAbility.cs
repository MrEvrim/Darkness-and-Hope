using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseOrbAbility : MonoBehaviour
{
    private FPSMouseLook fpsMouseLook;
    public GameObject AbilitySelectCanvas;
    AudioSource audioSource;
    void Start()
    {
        audioSource = transform.GetChild(4).GetChild(1).GetComponent<AudioSource>();
        fpsMouseLook = transform.GetChild(4).GetComponent<FPSMouseLook>();
    }
    void Update()
    {
        ChooseAbility();
    }

    void ChooseAbility()
    {
        if (Input.GetMouseButtonDown(1))
        {
            fpsMouseLook.enabled = false;
            AbilitySelectCanvas.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
        if(Input.GetMouseButtonUp(1))
        {
            audioSource.Play();
            fpsMouseLook.enabled = true;
            AbilitySelectCanvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
