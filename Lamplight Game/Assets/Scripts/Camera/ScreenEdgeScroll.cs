using DG.Tweening;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEdgeScroll : MonoBehaviour
{
    [Header("Camera To Use")]
    [Tooltip("The camera you want to control with edge scroll.")]
    public Transform MainCamera;

    public bool ScrollingEnabled = true;

    public bool ReturnToCenter = false;

    [Header("Top Screen Edge")]
    [Tooltip("Enable/disable detecting mouse enter on top edge.")]
    public bool MouseOnTopEdge = false;
    [Tooltip("Enable/disable scrolling behaviour.")]
    public bool TopScrollEnabled = false;
    [Tooltip("Enable rotation instead of scroll behaviour.")]
    public bool TopRotationEnabled = false;
    [Tooltip("Amounts to scroll by in X,Y,Z directions (float).")]
    public Vector3 TopScrollIncrement;
    [Tooltip("Amount to rotate along -X axis (float).")]
    public float TopRotationIncrement;
    [Tooltip("Top-most rotation boundary limit (float).")]
    public float TopMinRotationX;

    [Header("Right Screen Edge")]
    [Tooltip("Enable/disable detecting mouse enter on right edge.")]
    public bool MouseOnRightEdge = false;
    [Tooltip("Enable/disable scrolling behaviour.")]
    public bool RightScrollEnabled = false;
    [Tooltip("Enable rotation instead of scroll behaviour.")]
    public bool RightRotationEnabled = false;
    [Tooltip("Amounts to scroll by in X,Y,Z directions (float).")]
    public Vector3 RightScrollIncrement;
    [Tooltip("Amount to rotate along Y axis (float).")]
    public float RightRotationIncrement;
    [Tooltip("Right-most rotation boundary limit (float).")]
    public float RightMaxRotationY;

    [Header("Bottom Screen Edge")]
    [Tooltip("Enable/disable detecting mouse enter on bottom edge.")]
    public bool MouseOnBottomEdge = false;
    [Tooltip("Enable/disable scrolling behaviour.")]
    public bool BottomScrollEnabled = false;
    [Tooltip("Enable rotation instead of scroll behaviour.")]
    public bool BottomRotationEnabled = false;
    [Tooltip("Amounts to scroll by in X,Y,Z directions (float).")]
    public Vector3 BottomScrollIncrement;
    [Tooltip("Amount to rotate along X axis (float).")]
    public float BottomRotationIncrement;
    [Tooltip("Bottom-most rotation boundary limit (float).")]
    public float BottomMaxRotationX;

    [Header("Left Screen Edge")]
    [Tooltip("Enable/disable detecting mouse enter on bottom edge.")]
    public bool MouseOnLeftEdge = false;
    [Tooltip("Enable/disable scrolling behaviour.")]
    public bool LeftScrollEnabled = false;
    [Tooltip("Enable rotation instead of scroll behaviour.")]
    public bool LeftRotationEnabled = false;
    [Tooltip("Amounts to scroll by in X,Y,Z directions (float).")]
    public Vector3 LeftScrollIncrement;
    [Tooltip("Amount to rotate along -Y axis (float).")]
    public float LeftRotationIncrement;
    [Tooltip("Left-most rotation boundary limit (float).")]
    public float LeftMinRotationY;


    // Start is called before the first frame update

    public void Update()
    {
        if (ScrollingEnabled)
        {
            if (MouseOnTopEdge)
            {

                if (TopScrollEnabled && !TopRotationEnabled)
                {
                    MainCamera.transform.localPosition += TopScrollIncrement;
                }
                else if (TopScrollEnabled && TopRotationEnabled)
                {
                    if (MainCamera.transform.rotation.x >= TopMinRotationX)
                    {
                        MainCamera.transform.Rotate(TopRotationIncrement, 0.0f, 0.0f, Space.Self);
                    }
                }
                else
                {
                    return;
                }
            }

            else if (MouseOnLeftEdge)
            {

                if (LeftScrollEnabled && !LeftRotationEnabled)
                {
        
                    MainCamera.transform.localPosition += LeftScrollIncrement;
                }
                else if (LeftScrollEnabled && LeftRotationEnabled)
                {
         
                    // If the current Y rotation of the camera is >= Min rotation value.
                    if (MainCamera.transform.rotation.y >= LeftMinRotationY)
                    {
                        // Rotate the main camera along it's Y AXIS.
                        MainCamera.transform.Rotate(0.0f, LeftRotationIncrement, 0.0f, Space.World);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            else if (MouseOnBottomEdge)
            {

                if (BottomScrollEnabled && !BottomRotationEnabled)
                {
                    MainCamera.transform.localPosition += BottomScrollIncrement;
                }
                else if (BottomScrollEnabled && BottomRotationEnabled)
                {
                    // If the current Y rotation of the camera is >= Min rotation value.
                    if (MainCamera.transform.rotation.x <= BottomMaxRotationX)
                    {
                        // Rotate the main camera along it's Y AXIS.
                        MainCamera.transform.Rotate(BottomRotationIncrement, 0.0f, 0.0f, Space.Self);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            else if (MouseOnRightEdge)
            {

                if (RightScrollEnabled && !RightRotationEnabled)
                {
                    MainCamera.transform.localPosition += RightScrollIncrement;
                }
                else if (RightScrollEnabled && RightRotationEnabled)
                {
                    // If the current Y rotation of the camera is >= Min rotation value.
                    if (MainCamera.transform.rotation.y <= RightMaxRotationY)
                    {
                        // Rotate the main camera along it's Y AXIS.
                        MainCamera.transform.Rotate(0.0f, RightRotationIncrement, 0.0f, Space.World);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            else if (ReturnToCenter)
            {
                MainCamera.transform.DORotate(new Vector3(0, 0, 0), 1f);
            }

            else
            {
                return;
            }
        }
    }
        

    public void ScrollTop()
    {
        MouseOnTopEdge = true;
    }
    public void StopScrollTop()
    {
        MouseOnTopEdge = false;
    }

    public void ScrollRight()
    {
        MouseOnRightEdge = true;
    }
    public void StopScrollRight()
    {
        MouseOnRightEdge = false;
    }

    public void ScrollBottom()
    {
        MouseOnBottomEdge = true;
    }
    public void StopScrollBottom()
    {
        MouseOnBottomEdge = false;
    }

    public void ScrollLeft()
    {
        MouseOnLeftEdge = true;
    }
    public void StopScrollLeft()
    {
        MouseOnLeftEdge = false;
    }

    public void ToCenter()
    {
        ReturnToCenter = true;
    }

    public void StopToCenter()
    {
        ReturnToCenter = false;
    }

    public void EnableEdgeScroll()
    {
        ScrollingEnabled = true;
    }

    public void DisableEdgeScroll()
    {
        ScrollingEnabled = false;
        MainCamera.transform.DORotate(new Vector3(0, 0, 0), 1f);
    }
}
