using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseOrbAbility : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private FPSMouseLook fpsMouseLook;
    public GameObject AbilitySelectCanvas;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        fpsMouseLook = transform.GetChild(4).GetComponent<FPSMouseLook>();
    }
    void Update()
    {
        ChooseAbility();
    }

    void ChooseAbility()
    {
        if(Input.GetMouseButtonDown(1))
        {
            playerMovement.enabled = false;
            fpsMouseLook.enabled = false;
            AbilitySelectCanvas.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
        if(Input.GetMouseButtonUp(1))
        {
            playerMovement.enabled=true;
            fpsMouseLook.enabled = true;
            AbilitySelectCanvas.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log(SelectedOrb.SelectedAbilityIndex);
        }
    }
}
