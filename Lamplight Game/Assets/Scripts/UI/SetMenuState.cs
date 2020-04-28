using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMenuState : MonoBehaviour
{
    public MainMenuManager menuManger;
    private menuState state;
    public void setPlayState()
    {
        state = menuState.PLAY_MENU;
    }
    public void setSettingsState()
    {
        state = menuState.SETTINGS_MENU;
    }
    public void setMainMenuState()
    {
        state = menuState.MAIN_MENU;
    }
}
