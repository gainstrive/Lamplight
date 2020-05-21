using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEndTrigger : MonoBehaviour
{
    public SwordTrigger SwordScript;

    private void OnMouseEnter()
    {
        if (SwordScript.EventActivated)
        {
            SwordScript.SwordEventOut();
        }

    }
}
