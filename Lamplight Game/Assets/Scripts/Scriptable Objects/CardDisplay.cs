using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [Header("Card Properties")]
    public Card CardObject;
    public Text NameText;
    public Image Artwork;
    public Text Description;
    public Text CostText;
    public Color32 GemColor;
    public Color32 RibbonBottomColor;
    public Color32 RibbonTopColor;

    void Start()
    {
        /*
        nameText.text = card.name;
        descriptionText.text = card.description;
        costText.text = card.cost.ToString();
        */
        
    }
}
