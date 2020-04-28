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
    void Start()
    {
        state = menuState.AWAKE;
    }

    private void Update()
    {
        /* if (state == menuState.AWAKE)
        {
            MainMenuIn();
        }
        else if (state == menuState.MAIN_MENU_IN)
        {
            isAnimating = true;
        }
        else
        {
            return;
        }
        */
    }

    public void MainMenuIn()
    {
        mainMenuAnimator.Play("Main_Menu_In", 0);
        state = menuState.MAIN_MENU;
    }
    public void MainMenuOut()
    {
        mainMenuAnimator.Play("Main_Menu_Out", 0);
        //if (state == menuState.PLAY_MENU)
        //{
            StartCoroutine(PlayMenuIn());
        //}

    }

    public IEnumerator PlayMenuIn()
    {
        yield return new WaitForSeconds(playMenuTimeIn);
        playMenu.SetActive(true);


    }
}
