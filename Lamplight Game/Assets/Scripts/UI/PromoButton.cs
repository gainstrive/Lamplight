using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromoButton : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;
    public MainMenuManager menuManager;
    public void OpenURL() {
        Application.OpenURL("http://google.com/");
        Debug.Log("Working");
    }

    public void playHoverSFX()
    {
        if (menuManager.buttonsInteractible)
        {
            audioSource.PlayOneShot(hoverSFX);
        }
        else return;
    }

    public void playClickSFX()
    {
        if (menuManager.buttonsInteractible)
            audioSource.PlayOneShot(clickSFX);
        else return;
    }
}
