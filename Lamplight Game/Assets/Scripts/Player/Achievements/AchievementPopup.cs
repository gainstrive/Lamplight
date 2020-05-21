using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievementPopup : MonoBehaviour
{
    [Header("Scriptable Object")]
    public Achievement Achievement;
    [Header("GameObj References:")]
    public GameObject PopupObject;
    public TextMeshProUGUI AchievementNameText;
    public TextMeshProUGUI AchievementDescriptionText;
    public TextMeshProUGUI AchievementPointsText;
    public Animator PopupAnimator;
    public Image AchievementArtwork;
    public Image AchievementArtworkBackground;
    public Image AchievementGem;
    public float PopupPlayTime;
    public float PopupQuitTime;
    // public Image BannerTop;
    // public Image BannerBottom;
    // public Image SidePanel;
    void Start()
    {
        AchievementNameText.text = Achievement.Name;
        AchievementDescriptionText.text = Achievement.Description;
        AchievementPointsText.text = Achievement.Points.ToString();
        AchievementArtwork.sprite = Achievement.Artwork;
        AchievementArtworkBackground.sprite = Achievement.ArtworkBackground;
        AchievementGem.color = Achievement.GemColor;
        // BannerTop.color = Achievement.BannerTopColor;
        // BannerBottom.color = Achievement.BannerBottomColor;
        // SidePanel.color = Achievement.SidePanelColor;
        StartCoroutine("PlayAndDestroy");
    }

    private void Update()
    {

    }

    private IEnumerator PlayAndDestroy()
    {
        yield return new WaitForSeconds(PopupPlayTime);
        Destroy(PopupObject);
    }

    public void QuitPopup()
    {
        PopupAnimator.SetTrigger("PopupClicked");
        //PopupAnimator.Play("AchievementPopupQuit");
        StartCoroutine("QuitAndDestroy");
    }


    private IEnumerator QuitAndDestroy()
    {
        yield return new WaitForSeconds(PopupQuitTime);
        Destroy(PopupObject);
    }


}

