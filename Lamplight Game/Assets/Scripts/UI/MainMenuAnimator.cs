using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimator : MonoBehaviour
{
    public GameObject menuAnimator;
    public AudioManager audioManager;
    public GameObject playGameMenu;
    // Start is called before the first frame update
    public void MainMenuOut()
    {
        menuAnimator = GameObject.Find("Main_Menu");
        menuAnimator.GetComponent<Animator>().Play("Main_Menu_Out", 0);
        audioManager.Play("CardFlipStart");
        StartCoroutine(PlayMenuIn());
        
    }

    private IEnumerator PlayMenuIn()
    {
        yield return new WaitForSeconds(1.5f);
        playGameMenu.SetActive(true);

    }
}
