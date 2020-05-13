using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CardRotation : MonoBehaviour {

    public RectTransform CardFront;
    public RectTransform CardBack;
    public Transform CardFacePoint;
    public Collider Collider3D;

    private bool CardBackShowing = false;

	void Update () 
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(origin: Camera.main.transform.position, 
            direction: (-Camera.main.transform.position + CardFacePoint.position).normalized, 
            maxDistance: (-Camera.main.transform.position + CardFacePoint.position).magnitude) ;

        bool CardCollisionFound = false;

        foreach (RaycastHit h in hits)
        {
            if (h.collider == Collider3D)
                CardCollisionFound = true;
        }

        if (CardCollisionFound!= CardBackShowing)
        {
            CardBackShowing = CardCollisionFound;
            if (CardBackShowing)
            {
                CardFront.gameObject.SetActive(false);
                CardBack.gameObject.SetActive(true);
            }
            else
            {
                CardFront.gameObject.SetActive(true);
                CardBack.gameObject.SetActive(false);
            }

        }

	}
}
