using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject PlayerObject;
    public enum GameDifficulty {Normal, Hard, Nightmare}
    public GameDifficulty Difficulty;
    public int Level;
    public int HandSize;
    public string[] CardList;
    public bool[] Achievements;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    /* private void Update()
    {

        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            Debug.Log(this.Level);
            SaveSystem.SaveGame(this);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1)) {
            PlayerData Data = SaveSystem.LoadGame();
            Level = Data.Level;
            Debug.Log(Level);
        }
    }
    */

    public void SetDifficultyHard()
    {
        Difficulty = GameDifficulty.Hard;
    }
}