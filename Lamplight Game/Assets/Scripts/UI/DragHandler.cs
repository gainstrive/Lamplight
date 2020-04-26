using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public float originalPosX;
    public float originalPosY;
    public float initialPosX;
    public float initialPosY;
    public float currentPosX;
    public float currentPosY;
    public Vector3 scaleChange;
    public Vector3 currentScale;
    public float rotationChange;
    public float initalRotation;
    public float newRotation;
    Transform originalParent = null;


    public void OnMouseExit()
    {
        this.transform.localScale = new Vector3(1f, 1f, 0);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        originalPosX = this.transform.position.x;
        originalPosY = this.transform.position.y;
        initialPosX = this.transform.position.x;
        initialPosY = this.transform.position.y;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        currentPosX = this.transform.position.x;
        currentPosY = this.transform.position.y;

        currentScale = this.transform.localScale;
        if (currentPosY > initialPosY && currentScale.x >= 0.350002f)
        {
            scaleChange = new Vector3(-0.01f, -0.02f, 0.03f);
            this.transform.localScale += scaleChange;
            // Debug.Log("Dragging UP");
        }
        else if (currentPosY < initialPosY && currentScale.x < .45f)
        {
            scaleChange = new Vector3(0.01f, 0.02f, 0.03f);
            this.transform.localScale += scaleChange;
            // Debug.Log("Dragging DOWN");
        }

        this.transform.position = eventData.position;
        initialPosX = currentPosX;
        initialPosY = currentPosY;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(originalParent);
        // Check if dropped in a zone...
        // if dropped, play card.
        // else reset card to original position && scale.

        this.transform.position = new Vector3(originalPosX, originalPosY, 0);
        this.transform.localScale = new Vector3(.45f, .45f, 0);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Debug.Log(this.transform.position);
    }

}
