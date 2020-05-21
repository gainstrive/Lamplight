using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrigger : MonoBehaviour
{
    public Animator SwordAnimator;
    public AudioSource AudioSource;
    public AudioClip RuneSound;
    public bool EventActivated;
    // Start is called before the first frame update
    void Start()
    {
        EventActivated = false;

    }
    private void OnMouseEnter()
    {
        if (!EventActivated)
        {
            Debug.Log("Activating Sword Event.");
            EventActivated = true;
            StartCoroutine("SwordEvent");
        }
        else
        {
            Debug.Log("Event Already Activated.");
        }
    }

    public void PlayRuneSound(float SFXVolume)
    {
        AudioSource.volume = SFXVolume;
        AudioSource.PlayOneShot(RuneSound);
    }
    public IEnumerator SwordEvent()
    {
        SwordAnimator.SetTrigger("MouseOver");
        yield return new WaitForSeconds(.5f);
        PlayRuneSound(1);
        yield return new WaitForSeconds(.5f);
        PlayRuneSound(.8f);
        yield return new WaitForSeconds(.5f);
        PlayRuneSound(.7f);
        yield return new WaitForSeconds(.5f);
        PlayRuneSound(.9f);
        yield return new WaitForSeconds(.5f);
        PlayRuneSound(.6f);
    }

    public void SwordEventOut()
    {
        if (EventActivated)
        {
            Debug.Log("Fading Out Sword Event");
            SwordAnimator.SetTrigger("FadeOut");
        }
    }
}
