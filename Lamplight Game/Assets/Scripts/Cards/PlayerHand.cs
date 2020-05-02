using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHand : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject playerHand;
    public Animator playerHandAnimator;
    public AnimationState playerHandAnimState;
    public bool isAnimating = false;
    public float animTime;
    // public Vector3 scaleChange;
    // public Vector3 positionChange;

    public void OnPointerEnter(PointerEventData eventData)
    {
            playerHandAnimator.Play("Player_Hand_Zoom_In");
    }

    public IEnumerator setIsAnimating(bool condition)
    {
        yield return new WaitForSeconds(animTime);
        isAnimating = condition;
    }
    public void OnPointerExit(PointerEventData eventData) 
    {
            playerHandAnimator.Play("Player_Hand_Zoom_Out");
    }
}
