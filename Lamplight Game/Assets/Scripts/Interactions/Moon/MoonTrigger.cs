using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoonTrigger : MonoBehaviour
{
    public Animator MoonAnimator;
    public GameObject MoonParticles;
    public TextMeshPro DifficultyText;
    public Animator DifficultyTextAnimator;
    public AudioSource AudioSource;
    public AudioClip SecretDiscoveredSound;
    public AudioClip MoonShatterSound;
    public Player Player;
    public bool EventActivated;
    //public SpriteRenderer SpriteRenderer;
    //public Color EndColor;


    void Awake()
    {
        DifficultyTextAnimator.SetBool("TriggersEnabled", true); 
        MoonParticles.SetActive(false);
        EventActivated = false;
    }

    private void OnMouseDown()
    {
        if (!EventActivated)
        {
            EventActivated = true;
            AudioSource.PlayOneShot(SecretDiscoveredSound);
            StartCoroutine("StartMoonEvent");
        }
        else
        {
            Debug.Log("Event Already Activated.");
        }
    }

    public void OnMouseEnter()
    {
        DifficultyTextAnimator.SetBool("MouseOver", true);
    }

    public void OnMouseExit()
    {
        if (DifficultyTextAnimator.GetBool("TriggersEnabled") == true)
        {
            DifficultyTextAnimator.SetBool("MouseOver", false);
        }
        else
        {
            return;
        }
    }

    public IEnumerator StartMoonEvent()
    {

        DifficultyTextAnimator.SetBool("TriggersEnabled", false);
        DifficultyTextAnimator.SetBool("ChangeColor", true);
        Player.Difficulty = Player.GameDifficulty.Hard;
        MoonAnimator.Play("MoonColor");
        MoonParticles.SetActive(true);
        // DifficultyText.DOColor(new Color(1, 0, 0, 1), 2f);
        yield return new WaitForSeconds(2f);
        AudioSource.PlayOneShot(MoonShatterSound);
        DifficultyText.text = "HARD MODE ENABLED";
        yield return new WaitForSeconds(2f);
        DifficultyTextAnimator.SetBool("FadeOut", true);
    }
}
