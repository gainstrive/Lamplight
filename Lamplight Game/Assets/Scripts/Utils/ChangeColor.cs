using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    public Image image;
    public Color32 newColor;
    // Start is called before the first frame update
    void Start()
    {
        newColor = new Color32(25, 25, 25, 100);
        image.GetComponent<Image>().color = newColor;
    }

}
