using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PromoButton : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;

    public void OpenURL() {
        Application.OpenURL("http://google.com/");
        Debug.Log("Working");
    }

    public void playHoverSFX()
    {
        Debug.Log(hoverSFX);
        audioSource.PlayOneShot(hoverSFX);
    }
}
