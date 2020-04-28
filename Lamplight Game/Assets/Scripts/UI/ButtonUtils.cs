using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ButtonUtils : MonoBehaviour
{
    #region MenuManager
    public MainMenuManager menuManager;
    #endregion

    #region Audio
    public AudioSource audioSource;
    public AudioClip clickSFX;
    public AudioClip hoverSFX;
    public float sfxMinVolume;
    public float sfxMaxVolume;
    #endregion

    /* #region MenuTransitions
    public GameObject currentMenu;
    public Animator currentMenuAnimator;
    public GameObject nextMenu;
    public Animator nextMenuAnimator;
    #endregion
    */

    #region WebBrowser
    public string urlToOpen;
    #endregion
    float volumeRange;
    public void openURL()
    {
        Application.OpenURL(urlToOpen);
    }
    public void playHoverSFX()
    {
        if (menuManager.buttonsInteractible)
        {
            volumeRange = Random.Range(sfxMinVolume, sfxMaxVolume);
            audioSource.volume = Mathf.Round(volumeRange * 100f) / 100f;
            audioSource.PlayOneShot(hoverSFX);
        }
        else
        {
            return;
        }
    }

    public void playClickSFX()
    {
        if (menuManager.buttonsInteractible)
        {
            volumeRange = Random.Range(sfxMinVolume, sfxMaxVolume);
            audioSource.volume = Mathf.Round(volumeRange * 100f) / 100f;
            audioSource.PlayOneShot(clickSFX);
        }
        else
        {
            return;
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

}

