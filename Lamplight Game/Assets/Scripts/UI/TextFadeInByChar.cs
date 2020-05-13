using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeInByChar : MonoBehaviour
{
    [SerializeField] private Text textToUse;
    [SerializeField] private bool useThisText = false;
    [TextAreaAttribute(4, 15)]
    [SerializeField] private string textToShow;
    [SerializeField] private bool useTextText = false;
    [SerializeField] private float fadeSpeedMultiplier = 0.25f;
    [SerializeField] private bool fade = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private bool useThisAudioSource = false;
    [SerializeField] public bool playSound = false;
    [SerializeField, Range(0.0f, 1f)] public float soundVolMin;
    [SerializeField, Range(0.0f, 1f)] public float soundVolMax;
    private float colorFloat = 0.1f;
    private int colorInt;
    private int letterCounter = 0;
    private string shownText;
    private void Start()
    {
        if (useThisText)
        {
            textToUse = GetComponent<Text>();
        }
        if (useTextText)
        {
            textToShow = textToUse.text;
        }
        if (useThisAudioSource)
        {
            audioSource = GetComponent<AudioSource>();
        }
        if (fade)
        {
            Fade();
        }
    }
    private IEnumerator FadeInText()
    {
        while (letterCounter < textToShow.Length)
        {
            if (colorFloat < 1.0f)
            {
                colorFloat += Time.deltaTime * fadeSpeedMultiplier;
                colorInt = (int)(Mathf.Lerp(0.0f, 1.0f, colorFloat) * 255.0f);
                textToUse.text = shownText + "<color=\"#FFFFFF" + string.Format("{0:X}", colorInt) + "\">" + textToShow[letterCounter] + "</color>";
            }
            else
            {
                colorFloat = 0.1f;
                shownText += textToShow[letterCounter];
                letterCounter++;
                
                if (playSound)
                {
                        audioSource.volume = Random.Range(soundVolMin, soundVolMax);
                        float RandomPitch = Random.Range(0f, 1f);

                        if (RandomPitch < .5)
                        {
                            RandomPitch = 1f;
                        }
                        else
                        {
                            RandomPitch = 1.02f;
                        }
                        audioSource.pitch = RandomPitch;
                        audioSource.Play();
                }
            }
            yield return null;
        }
    }
    public void Fade()
    {
        StartCoroutine(FadeInText());
    }

    public void StopSound()
    {
        playSound = false;
    }
}
