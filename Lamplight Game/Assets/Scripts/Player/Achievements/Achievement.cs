using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achievement", menuName = "Achievement")]
public class Achievement : ScriptableObject
{
    [Header("Achievement Information:")]
    public string Name;
    public int Points;
    [TextArea(2, 3)]
    public string Description;
    public Sprite Artwork;
    public Sprite ArtworkBackground;
    [ColorUsageAttribute(true, true)]
    public Color BannerTopColor;
    [ColorUsageAttribute(true, true)]
    public Color BannerBottomColor;
    [ColorUsageAttribute(true, true)]
    public Color SidePanelColor;
    [ColorUsageAttribute(true, true)]
    public Color GemColor;
}