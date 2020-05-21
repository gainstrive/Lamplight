using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;

public static class SaveSystem
{
    public static void SaveGame (Player Player)
    {
        BinaryFormatter Formatter = new BinaryFormatter();
        string FilePath = Application.persistentDataPath + "/Player.save";
        FileStream Stream = new FileStream(FilePath, FileMode.Create);

        PlayerData Data = new PlayerData(Player);
        Formatter.Serialize(Stream, Data);
        Debug.Log("Saved Game @ " + FilePath);
        // EditorUtility.RevealInFinder(FilePath);
        Stream.Close();
    }

    public static PlayerData LoadGame ()
    {
        string FilePath = Application.persistentDataPath + "/Player.save";

        if (File.Exists(FilePath))
        {
            Debug.Log("Loading Game @ " + FilePath);
            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream Stream = new FileStream(FilePath, FileMode.Open);
            PlayerData Data = Formatter.Deserialize(Stream) as PlayerData;
            Stream.Close();
            return Data;
        }
        else
        {
            Debug.Log("No Save @ " + FilePath);
            return null;
        }
    }
}
