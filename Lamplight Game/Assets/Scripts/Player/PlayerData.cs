using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Level;
    public int HandSize;
    public string[] CardList;
    public bool[] Achievements;
    public PlayerData (Player Player)
    {
        Level = Player.Level;
        Achievements = Player.Achievements;
    }
}
