using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    [Header("Card Information")]

    // Defines which character "class" can use this card.
    // If NULL, any character can use the card.
    public CharacterType CharacterType;

    // Defines the type of card.
    public enum CardType 
    {
        Attack,
        Item,
        Spell,
        Effect,
        Equipment
    }
    public enum TargetingOptions
    {
        None,
        All,
        Enemies,
        Player
    }
    // A reference to the card art's sprite to use.
    public Sprite Artwork;

    [TextArea(2,3)]
    // The "body" text of the card.
    // Indicates what the card will do.
    public string Description;

    // The initial cost of playing the card.
    public int Cost;

    // The name of the script to attach to card.
    public string ScriptName;

    [ColorUsageAttribute(true, true)]
    public Color GemColor;
    [ColorUsageAttribute(true, true)]
    public Color RibbonTopColor;
    [ColorUsageAttribute(true, true)]
    public Color RibbonBottomColor;
    public TargetingOptions Targets;


}
