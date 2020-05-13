using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerLight : MonoBehaviour
{
    public Transform objectToMove;
    //public Texture2D cursorTex;
    //public Vector2 hotspot;
    //public CursorMode cursorMode = CursorMode.Auto;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.SetCursor(cursorTex, hotspot, cursorMode);
    }

    Vector3 worldPosition;

void Update()
    {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            objectToMove.transform.position = worldPosition;
    }
}
