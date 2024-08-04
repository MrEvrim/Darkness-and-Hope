using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectedOrb : MonoBehaviour
{
    public static int SelectedAbilityIndex;
    //public GameObject orb;
    public Color[] colors;

    private void Start()
    {
        transform.GetChild(4).GetChild(1).GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", colors[4]);
        SelectedAbilityIndex = 4;
    }
    public void jumpSelect()
    {
        SelectedAbilityIndex = 0;
        transform.GetChild(4).GetChild(1).GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", colors[0]);
    }
    public void CarrierSelect()
    {
        SelectedAbilityIndex = 3;
        transform.GetChild(4).GetChild(1).GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", colors[3]);
    }
    public void LightSelect()
    {
        SelectedAbilityIndex = 1;
        transform.GetChild(4).GetChild(1).GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", colors[1]);
    }
    public void SpeedSelect()
    {
        SelectedAbilityIndex = 2;
        transform.GetChild(4).GetChild(1).GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", colors[2]);
    }
}
