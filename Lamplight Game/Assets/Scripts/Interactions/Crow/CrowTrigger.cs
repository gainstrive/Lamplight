using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowTrigger : MonoBehaviour
{
    private bool EventActivated = false;
    public GameObject CrowFlying1;

    private void Awake()
    {
        CrowFlying1.SetActive(false);
    }
    private void OnMouseEnter()
    {
        if (!EventActivated)
        {
            Debug.Log("Activating \"Crow Event\".");
            CrowFlying1.SetActive(true);
            EventActivated = true;
        }
        else
        {
            Debug.Log("\"Crow Event\" already activated.");
        }
    }
}
