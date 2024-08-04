using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrbAbilities: MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float jumpPower;
    [SerializeField] private float jumpUseRate;
    private PlayerMovement playerMovement;
    public Light orbLight;
    private float _timer;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        useAbility();
    }

    void useAbility()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (SelectedOrb.SelectedAbilityIndex)
            {
                case 0:
                    if (_timer >= jumpUseRate)
                    {
                        _timer = 0;
                        rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
                    }
                    break;
                case 1:
                    orbLight.intensity = 2.8f;
                    break;
                case 2:
                    playerMovement.walkSpeed = 17f;
                    break;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            playerMovement.walkSpeed = 2f;
            orbLight.intensity = 0.2f;
        }
    }
}
