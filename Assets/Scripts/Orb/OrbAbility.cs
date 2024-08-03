using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbAbility : MonoBehaviour
{
    public Material[] orbMaterials;
    void Start()
    {
        SelectedOrb.SelectedAbilityIndex = 4;
        this.gameObject.GetComponent<MeshRenderer>().material = orbMaterials[4];
    }

    void Update()
    {
        switch(SelectedOrb.SelectedAbilityIndex)
        {
            case 0:
                this.gameObject.GetComponent<MeshRenderer>().material = orbMaterials[0];
                break;
            case 1:
                this.gameObject.GetComponent<MeshRenderer>().material = orbMaterials[1];
                break;
            case 2:
                this.gameObject.GetComponent<MeshRenderer>().material = orbMaterials[2];
                break;
            case 3:
                this.gameObject.GetComponent<MeshRenderer>().material = orbMaterials[3];
                break;
        }
    }
}
