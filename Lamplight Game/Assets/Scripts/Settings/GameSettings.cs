using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSettings : MonoBehaviour
{
    public bool tooltipsEnabled;
    public bool tutorialEnabled;
    public bool postProcessEnabled;
    public bool bloomEnabled;
    public bool colorGradingEnabled;
    public bool filmGrainEnabled;
    public bool vignetteEnabled;
    public enum gameDifficulty { EASY, NORMAL, HARD, NIGHTMARE }
    public float masterVolume;
    public float sfxVolume;
    public float musicVolume;

}
