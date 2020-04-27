using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimator : MonoBehaviour
{
    public GameObject menuAnimator;
    public AudioManager audioManager;
    // Start is called before the first frame update
    public void MainMenuOut()
    {
        menuAnimator = GameObject.Find("Main_Menu");
        menuAnimator.GetComponent<Animator>().Play("Main_Menu_Out", 0);
        audioManager.Play("CardFlipStart");

        
    }
}
