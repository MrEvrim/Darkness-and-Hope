using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedOrb : MonoBehaviour
{
    public static int SelectedAbilityIndex;

    public void jumpSelect()
    {
        SelectedAbilityIndex = 0;
    }
    public void CarrierSelect()
    {
        SelectedAbilityIndex = 1;
    }
    public void LightSelect()
    {
        SelectedAbilityIndex = 2;
    }
    public void ShockWaveSelect()
    {
        SelectedAbilityIndex = 3;
    }
}
