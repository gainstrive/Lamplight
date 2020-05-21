using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("GameObj References:")]
    public GameObject EventTriggers;
    public GameObject CursorLight;
    public GameObject InstructionsText;
    public GameObject FadeIn;
    public GameObject ScrollingText;
    public GameObject TestLight;
    public GameObject ScrollingTextAnimator;
    public GameObject LampParticles;
    [Header("UI References:")]
    public Button LampButton;
    [Header("Animator References:")]
    public Animator LampAnimator;
    public Animator InstructionsAnimator;
    public Animator SceneAnimator;
    [Header("Audio References:")]
    public AudioSource AudioSource;
    public AudioClip WalkSoundToPlay;
    public AudioClip Walk1;
    public AudioClip Walk2;
    public AudioClip Walk3;
    public AudioClip Walk4;


    public void StartWalkSounds()
    {
        InvokeRepeating("PlayWalkingSounds", 0.2f, 1.5f);
    }

    public void StopWalkingSounds()
    {
        CancelInvoke("PlayWalkingSounds");
    }

    public void PlayWalkingSounds()
    {
        int RandomSound = UnityEngine.Random.Range(0, 2);
        switch (RandomSound)
        {
            case 0:
                AudioSource.clip = Walk1;
                break;
            case 1:
                AudioSource.clip = Walk2;
                break;
            case 2:
                AudioSource.clip = Walk3;
                break;
            case 3:
                AudioSource.clip = Walk4;
                break;
            default:
                break;
        }
        AudioSource.Play();
    }

    private void Awake()
    {
        EventTriggers.SetActive(false);
        TestLight.SetActive(false);
        ScrollingText.SetActive(false);
        CursorLight.SetActive(false);
        InstructionsText.SetActive(false);
        LampButton.interactable = false;
    }
    private void Start()
    {
        FadeIn.SetActive(true);
        StartCoroutine(InstructionsIn());
    }
    public void hideLamp()
    {
        LampAnimator.Play("LampOut");
        InstructionsAnimator.Play("InstructionsOut");
        LampParticles.SetActive(false);
        StartCoroutine(EnableCursorLight());
    }

    public IEnumerator EnableCursorLight()
    {
        yield return new WaitForSeconds(2.8f);
        CursorLight.SetActive(true);
        StartCoroutine(SceneStart());
    }
    
    public IEnumerator SceneStart()
    {
        yield return new WaitForSeconds(1f);
        ScrollingTextAnimator.SetActive(true);
        SceneAnimator.Play("ScrollingScene");
        EventTriggers.SetActive(true);
        StartWalkSounds();
    }

    public IEnumerator InstructionsIn()
    {
        yield return new WaitForSeconds(2f);
        FadeIn.SetActive(false);
        yield return new WaitForSeconds(1f);
        InstructionsText.SetActive(true);
        yield return new WaitForSeconds(2f);
        LampButton.interactable = true;
    }

    public void DisableLampButon()
    {
        LampButton.interactable = false;
    }
}
