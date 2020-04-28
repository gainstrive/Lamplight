using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public enum menuState { AWAKE, MAIN_MENU, PLAY_MENU, SETTINGS_MENU}

public class MainMenuManager : MonoBehaviour
{

    public bool buttonsInteractible;
    public menuState state;
    public bool isAnimating;
    public GameObject mainMenu;
    public Animator mainMenuAnimator;
    [Range(0.0f, 100.0f)]
    public float mainMenuTimeIn;
    [Range(0.0f, 100.0f)]
    public float mainMenuTimeOut;
    public GameObject playMenu;
    public Animator playMenuAnimator;
    [Range(0.0f, 100.0f)]
    public float playMenuTimeIn;
    [Range(0.0f, 100.0f)]
    public float playMenuTimeOut;

    // Start is called before the first frame update
    void Awake()
    {
        buttonsInteractible = false;
        StartCoroutine(initButtonsInteractible());
        state = menuState.AWAKE;   
    }

    public IEnumerator initButtonsInteractible()
    {
        yield return new WaitForSeconds(mainMenuTimeIn);
        buttonsInteractible = true;
    }
    public IEnumerator PlayMenuOutMainMenuIn()
    {
        buttonsInteractible = false;
        yield return new WaitForSeconds(playMenuTimeOut);
        playMenu.SetActive(false);
        yield return new WaitForSeconds(mainMenuTimeIn);
        mainMenuAnimator.Play("Main_Menu_In", 0);
        state = menuState.MAIN_MENU;
    }
    public void mainMenuOutPlayMenuIn()
    {
            StartCoroutine(MainMenuOutPlayMenuIn());
    }

    public IEnumerator MainMenuOutPlayMenuIn()
    {
        buttonsInteractible = false;
        mainMenuAnimator.Play("Main_Menu_Out", 0);
        yield return new WaitForSeconds(mainMenuTimeOut);
        playMenu.SetActive(true);
        yield return new WaitForSeconds(playMenuTimeIn);
        mainMenu.SetActive(false);
        buttonsInteractible = true;
    }


}
